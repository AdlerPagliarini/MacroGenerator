using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using TopML;

namespace MSDN_TeclasForm
{
    public partial class TopMacro : Form
    {
        bool run = false;
        string mySession = "";
        string myID = "";
        int repeat = 0;
        int timeFastWait = 250;
        int timeWait = 500;

        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd);


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);
        [StructLayout(LayoutKind.Sequential)]

        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };
        public static Point GetMousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }

        private void TopMacro_Load(object sender, EventArgs e)
        {
        }


        public TopMacro(string id, string session)
        {
            InitializeComponent();
            mySession = session;
            myID = id;
        }
        public bool userSession(string id, string value)
        {
            return true;
        }
        public int readScript(int startIndex, int sizeRepeat)
        {
            int i = 0;
            try
            {
                if (!userSession(myID, mySession))
                {
                    return -1; //exit
                }
                int until = (lstComandos.Items.Count - 1);
                for (i = startIndex; i <= until; i++)
                {
                    lstComandos.SelectedIndex = i;
                    string comand = lstComandos.Items[i].ToString();
                    if (comand.Contains("StartRepeat#") && run)
                    {
                        int subComand = Convert.ToInt32(comand.Split('#')[1]);
                        int startRepeat = i + 1;
                        int y = 1;
                        int restartFrom = i + 1;
                        for (y = 1; y < subComand; y++)
                        {
                            readScript(startRepeat, getSizeWhile(comand));
                        }
                        lstComandos.SelectedIndex = i;
                    }
                    else if (comand.Contains("mouseLC#") && run)
                    {
                        string subComand = Convert.ToString(comand.Split('#')[1]);
                        string[] p = subComand.Split(',');
                        MouseLeftClick(Convert.ToInt32(p[0]), Convert.ToInt32(p[1]));
                    }
                    else if (comand.Contains("mouseRC#") && run)
                    {
                        string subComand = Convert.ToString(comand.Split('#')[1]);
                        string[] p = subComand.Split(',');
                        MouseRightClick(Convert.ToInt32(p[0]), Convert.ToInt32(p[1]));
                    }
                    else if (comand.Contains("mouseSelect&Move#") && run)
                    {//0,0#0,0
                        string[] subComand = comand.Split('#');
                        string[] p = subComand[1].Split(',');
                        string[] p2 = subComand[2].Split(',');
                        MouseSelectMove(Convert.ToInt32(p[0]), Convert.ToInt32(p[1]), Convert.ToInt32(p2[0]), Convert.ToInt32(p2[1]));
                    }
                    else if (comand.Contains("openWindow#") && run)
                    {
                        string subComand = Convert.ToString(comand.Split('#')[1]);
                        openWindow(subComand);
                    }
                    else if (comand.Contains("pressKey#") && run)
                    {
                        string subComand = Convert.ToString(comand.Split('#')[1]);
                        if (subComand[1] == ' ')
                        {
                            PressKey(" ");
                        }
                        else if ((subComand[1] == '/') && (subComand[2] == 'w'))
                        {
                            int start = 0;
                            int end = subComand.Length;
                            foreach (char c in subComand)
                            {
                                if (start > 2 && start < (end - 1))
                                {
                                    if (c == ' ')
                                    {
                                        PressKey(" ");
                                    }
                                    else
                                    {
                                        PressKey("{" + c + "}");
                                    }
                                }
                                start++;
                            }
                        }
                        else
                        {
                            PressKey(subComand);
                        }
                    }
                    else if (comand.Contains("waitFor#") && run)
                    {
                        string subComand = Convert.ToString(comand.Split('#')[1]);
                        waitFor(Convert.ToInt32(subComand));
                    }
                    else if (comand.Contains("StopRepeat") && sizeRepeat == getSizeWhile(comand))
                    {
                        return i;
                    }
                }
                return 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error at line " + Convert.ToString(i) + ".");
                return 1;
            }
        }

        public int getSizeWhile(string source)
        {
            int x = 0;
            foreach (char c in source)
                if (c == '_') x++;
            return x;
        }
        private void addComand(string value)
        {
            value = value.Trim();
            if (lstComandos.SelectedIndex >= 0)
            {
                string source = Convert.ToString(lstComandos.SelectedItem);
                int x = getSizeWhile(source);
                if (Convert.ToString(lstComandos.SelectedItem).Contains("StopRepeat"))
                {
                    x++;
                }
                for (int y = 0; y < x; y++)
                {
                    value = "_ " + value;
                }
                if (value.Contains("StopRepeat"))
                {
                    if (checkStartToAdd() && lstComandos.SelectedIndex >= 1)
                    {
                        lstComandos.Items.Insert(lstComandos.SelectedIndex, value);
                    }
                    else
                    {
                        MessageBox.Show("To add this line, you must to have a StartRepeat before!");
                    }
                }
                else
                {
                    if (Convert.ToString(lstComandos.SelectedItem).Contains("StartRepeat"))
                    {
                        MessageBox.Show("You can't StartRepeat in this line, select the prev or next line!");
                    }
                    else
                    {
                        lstComandos.Items.Insert(lstComandos.SelectedIndex, value);
                    }
                }

            }
            else
            {
                for (int x = 0; x < repeat; x++)
                {
                    value = "_ " + value;
                }
                lstComandos.Items.Add(value);
            }
        }
        private bool checkStartToAdd(bool write = false, int posNotWrite = -1)
        {
            string code = Convert.ToString(lstComandos.SelectedItem);
            int position = lstComandos.SelectedIndex;
            if (code.Contains("StartRepeat"))
            {
                code = Convert.ToString(lstComandos.Items[lstComandos.SelectedIndex - 1]);
                position = lstComandos.SelectedIndex - 1;
                if (code.Contains("StartRepeat"))
                {
                    return false;
                }
            }
            int sizeStart = getSizeWhile(code);
            if (code.Contains("StopRepeat"))
            {
                sizeStart++;
            }
            int sizeStop = -1;
            string value = Convert.ToString(lstComandos.Items[position]);
            sizeStop = getSizeWhile(value);

            while ((!value.Contains("StartRepeat")) && position >= 0)
            {
                position--;
                if (position >= 0)
                {
                    value = Convert.ToString(lstComandos.Items[position]);
                    if (write && (position != posNotWrite && !value.Contains("StartRepeat")))//quando ele chama recursivamente é pq vai da certo então eu chamo a função de novo para escrever dentro do repeat
                    {
                        lstComandos.Items[position] = "_ " + Convert.ToString(lstComandos.Items[position]);
                    }
                    if ((value.Contains("StopRepeat")))
                    {
                        return false;
                    }
                    sizeStop = getSizeWhile(value);
                }
                else
                {
                    return false;
                }
            }
            if (sizeStart == sizeStop)
            {
                if (!write)
                {
                    checkStartToAdd(true, position);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MouseSelectMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            Afkvalley.MouseMove(xStart, yStart);
            Thread.Sleep(timeWait);
            Afkvalley.MouseClick("left", 0);
            Thread.Sleep(timeWait);
            Afkvalley.MouseMove(xEnd, yEnd);
            Thread.Sleep(timeWait);
            Afkvalley.MouseClick("left", 1);
            Thread.Sleep(timeWait);
        }
        private void MouseLeftClick(int x, int y)
        {
            Afkvalley.MouseMove(x, y);
            Thread.Sleep(timeFastWait);
            Afkvalley.MouseClick("left", 0);
            Thread.Sleep(timeFastWait);
            Afkvalley.MouseClick("left", 1);
            Thread.Sleep(timeWait);
        }

        private void MouseRightClick(int x, int y)
        {
            Afkvalley.MouseMove(x, y);
            Thread.Sleep(timeFastWait);
            Afkvalley.MouseClick("right", 0);
            Thread.Sleep(timeFastWait);
            Afkvalley.MouseClick("right", 1);
            Thread.Sleep(timeWait);
        }

        private void waitFor(int x)
        {
            Thread.Sleep(x);
        }

        private void PressKey(string key)
        {
            if (string.IsNullOrEmpty(key) || key == " " || key == "")
            {
                SendKeys.SendWait(" ");
            }
            else
            {
                SendKeys.SendWait(key);
            }
            Thread.Sleep(timeWait);
        }

        private void openWindow(string window)
        {
            try
            {
                Thread.Sleep(500);
                IntPtr windowHandle = FindWindow(window.Split('/')[0], window.Split('/')[1]);
                IntPtr foreGroundFirst = GetForegroundWindow();

                if (windowHandle == IntPtr.Zero)
                {
                    MessageBox.Show("Process is not running.");
                    return;
                }

                while (windowHandle != GetForegroundWindow())
                {
                    SetForegroundWindow(windowHandle);
                }
            }
            catch
            {
                MessageBox.Show("Error on open window.");
            }
        }
        private void btnMouse_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Point mP = GetMousePosition();
            txtX.Text = Convert.ToString(mP.X);
            txtY.Text = Convert.ToString(mP.Y);

            txtXLC.Text = Convert.ToString(mP.X);
            txtYLC.Text = Convert.ToString(mP.Y);

            txtXRC.Text = Convert.ToString(mP.X);
            txtYRC.Text = Convert.ToString(mP.Y);

            txtXSLC.Text = Convert.ToString(mP.X);
            txtYSLC.Text = Convert.ToString(mP.Y);

            txtX.BackColor = Color.White;
            txtY.BackColor = Color.White;
        }

        private void TopMacro_FormClosing(object sender, FormClosingEventArgs e)
        {
            run = false;
            Thread.Sleep(1000);
            btnStop.Enabled = false;
        }

        private void btnGetSY_Click(object sender, EventArgs e)
        {
            txtXMoveTo.Enabled = false;
            txtYMoveTo.Enabled = false;
            Thread.Sleep(2000);
            Point mP = GetMousePosition();
            txtXMoveTo.Text = Convert.ToString(mP.X);
            txtYMoveTo.Text = Convert.ToString(mP.Y);
            txtXMoveTo.Enabled = true;
            txtYMoveTo.Enabled = true;
        }

        private void btnAddSMove_Click(object sender, EventArgs e)
        {
            addComand("mouseSelect&Move#" + txtXSLC.Text + "," + txtYSLC.Text + "#" + txtXMoveTo.Text + "," + txtYMoveTo.Text);
        }

        private void btnSRepeat_Click(object sender, EventArgs e)
        {
            addComand("StartRepeat#" + txtRepeat.Text);
            repeat++;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string code = Convert.ToString(lstComandos.SelectedItem);
            int position = lstComandos.SelectedIndex;
            int sizeStart = getSizeWhile(code);
            int sizeStop = -1;
            position++;

            if (code.Contains("StartRepeat") && checkStopToRemove())
            {
                string value = Convert.ToString(lstComandos.Items[position]);
                sizeStop = getSizeWhile(value);
                while ((!value.Contains("StopRepeat") || sizeStart != sizeStop))
                {
                    lstComandos.Items[position] = Convert.ToString(lstComandos.Items[position]).Substring(2, Convert.ToString(lstComandos.Items[position]).Length - 2);
                    position++;
                    value = Convert.ToString(lstComandos.Items[position]);
                    sizeStop = getSizeWhile(value);
                }
                lstComandos.Items.RemoveAt(position);
                lstComandos.Items.RemoveAt(lstComandos.SelectedIndex);
            }
            else
            {
                for (int i = lstComandos.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstComandos.Items.RemoveAt(lstComandos.SelectedIndices[i]);

                }
            }

        }

        private bool checkStopToRemove()
        {

            string code = Convert.ToString(lstComandos.SelectedItem);
            int position = lstComandos.SelectedIndex;
            int sizeStart = getSizeWhile(code);
            int sizeStop = -1;
            position++;
            if (lstComandos.Items.Count <= position)
            {
                return false;
            }
            string value = Convert.ToString(lstComandos.Items[position]);
            sizeStop = getSizeWhile(value);

            while ((!value.Contains("StopRepeat")) && position < lstComandos.Items.Count)
            {
                position++;
                if (position < lstComandos.Items.Count)
                {
                    value = Convert.ToString(lstComandos.Items[position]);
                    sizeStop = getSizeWhile(value);
                }
                else
                {
                    return false;
                }
            }
            if (sizeStart == sizeStop)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnResetSelect_Click(object sender, EventArgs e)
        {
            lstComandos.SelectedIndex = -1;
        }

        private void btnEndRepeat_Click(object sender, EventArgs e)
        {
            repeat--;
            if (repeat < 0)
            {
                repeat = 0;
            }
            addComand("StopRepeat");
        }

        private void btnAddLeftClick_Click(object sender, EventArgs e)
        {
            addComand("mouseLC#" + txtXLC.Text + "," + txtYLC.Text);
        }

        private void btnAddRightClick_Click(object sender, EventArgs e)
        {
            addComand("mouseRC#" + txtXLC.Text + "," + txtYLC.Text);
        }

        private void btnAddOpen_Click(object sender, EventArgs e)
        {
            addComand("openWindow#" + txtNomeJanela.Text);
        }

        private void btnPressKey_Click(object sender, EventArgs e)
        {
            addComand("pressKey#" + txtPKey.Text);
        }
        private void btnWait_Click(object sender, EventArgs e)
        {
            addComand("waitFor#" + txtWait.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "topmacro.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                for (int i = 0; i < lstComandos.Items.Count; i++)
                {
                    writer.WriteLine(lstComandos.Items[i].ToString());
                }
                writer.Dispose();
                writer.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstComandos.Items.Clear();
            OpenFileDialog fileOpen = new OpenFileDialog();
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string filename = fileOpen.FileName;

                string[] filelines = File.ReadAllLines(filename);
                foreach (string v in filelines)
                {
                    lstComandos.Items.Add(v);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            do
            {
                if (userSession(myID, mySession))
                {
                    run = true;
                    btnStop.Enabled = true;
                    btnStart.Enabled = false;
                    readScript(0, -1);
                }
            } while (btnAutoRestart.Checked);
            run = false;
            Thread.Sleep(1000);
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btnHelpCodes_Click(object sender, EventArgs e)
        {
            TopKeysCode op = new TopKeysCode();
            op.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            run = false;
            btnAutoRestart.Checked = false;
        }
    }
}
