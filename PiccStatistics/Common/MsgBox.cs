using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics
{
    public partial class MsgBox : DevComponents.DotNetBar.Office2007Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        [DllImport("Shell32.dll")]
        public extern static int ExtractIconEx(string libName, int iconIndex, IntPtr[] largeIcon, IntPtr[] smallIcon, int nIcons);

        static private IntPtr[] largeIcon;
        static private IntPtr[] smallIcon;

        static private MsgBox newMessageBox;
        static private LabelX frmTitle;
        static private LabelX frmMessage;
        static private PictureBox pIcon;
        static private FlowLayoutPanel flpButtons;
        static private Icon frmIcon;
        

        static private ButtonX btnOK;
        static private ButtonX btnAbort;
        static private ButtonX btnRetry;
        static private ButtonX btnIgnore;
        static private ButtonX btnCancel;
        static private ButtonX btnYes;
        static private ButtonX btnNo;
        static private ImageList il=new ImageList();
        public MsgBox()
        {
            this.EnableGlass = false;
            
            InitializeComponent();
            
        }

        static private DialogResult CYReturnButton;

        public enum MyIcon
        {
            Error,
            Explorer,
            Find,
            Information,
            Mail,
            Media,
            Print,
            Question,
            RecycleBinEmpty,
            RecycleBinFull,
            Stop,
            User,
            Warning
        }

        public enum MyButtons
        {
            AbortRetryIgnore,
            OK,
            OKCancel,
            RetryCancel,
            YesNo,
            YesNoCancel
        }

        static private void BuildMessageBox(string title)
        {
            newMessageBox = new MsgBox();
            newMessageBox.Text = title;
            newMessageBox.Size = new System.Drawing.Size(308, 146);
            newMessageBox.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //newMessageBox.ShowIcon = false;

            //newMessageBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //newMessageBox.Paint += new PaintEventHandler(newMessageBox_Paint);
            //newMessageBox.BackColor = System.Drawing.Color.White;

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.RowCount = 3;
            tlp.ColumnCount = 0;
            tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
   

            frmTitle = new LabelX();
            frmTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            frmMessage = new LabelX();
            frmMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            frmMessage.Text = "hiii";
            frmMessage.Font= new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            frmMessage.PaddingBottom = 16;

            largeIcon = new IntPtr[250];
            smallIcon = new IntPtr[250];
            pIcon = new PictureBox();
            
            ExtractIconEx("shell32.dll", 0, largeIcon, smallIcon, 250);

            flpButtons = new FlowLayoutPanel();
            flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            // flpButtons.Anchor = AnchorStyles.Right;

            TableLayoutPanel tlpMessagePanel = new TableLayoutPanel();
            tlpMessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMessagePanel.ColumnCount = 2;
            tlpMessagePanel.RowCount = 0;
            tlpMessagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50));
            tlpMessagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMessagePanel.Controls.Add(pIcon);
            tlpMessagePanel.Controls.Add(frmMessage);

            tlp.Controls.Add(frmTitle);
            tlp.Controls.Add(tlpMessagePanel);
            tlp.Controls.Add(flpButtons);
            newMessageBox.Controls.Add(tlp);
        }

        /// <summary>
        /// Message: Text to display in the message box.
        /// </summary>
        static public DialogResult Show(string Message)
        {
            BuildMessageBox("");
            //frmMessage.Text = Message;
            ShowOKButton();
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        /// <summary>
        /// Title: Text to display in the title bar of the messagebox.
        /// </summary>
        static public DialogResult Show(string Message, string Title)
        {
            BuildMessageBox(Title);
            //frmTitle.Text = Title;
            frmMessage.Text = Message;
            //ButtonStatements(MButtons);
            ShowOKButton();
            IconStatements();
            Image imageIcon = new Bitmap(frmIcon.ToBitmap(), 38, 38);
            pIcon.Image = imageIcon;
            //pIcon.Image = il.Images[0];
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        /// <summary>
        /// MButtons: Display MyButtons on the message box.
        /// </summary>
        static public DialogResult Show(string Message, string Title, MyButtons MButtons)
        {
            BuildMessageBox(Title); // BuildMessageBox method, responsible for creating the MessageBox
            //frmTitle.Text = Title; // Set the title of the MessageBox
            frmMessage.Text = Message; //Set the text of the MessageBox
            ButtonStatements(MButtons); // ButtonStatements method is responsible for showing the appropreiate buttons
            newMessageBox.ShowDialog(); // Show the MessageBox as a Dialog.
            return CYReturnButton; // Return the button click as an Enumerator
        }

        /// <summary>
        /// MIcon: Display MyIcon on the message box.
        /// </summary>
        static public DialogResult Show(string Message, string Title, MyButtons MButtons, MyIcon MIcon)
        {
            BuildMessageBox(Title);
            //frmTitle.Text = Title;
            frmMessage.Text = Message;
            ButtonStatements(MButtons);
            IconStatements();
            Image imageIcon = new Bitmap(frmIcon.ToBitmap(), 38, 38);
            pIcon.Image = imageIcon;
            //pIcon.Image = il.Images[0];
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        static void btnOK_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.OK;
            newMessageBox.Close();
        }

        static void btnAbort_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Abort;
            newMessageBox.Close();
        }

        static void btnRetry_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Retry;
            newMessageBox.Close();
        }

        static void btnIgnore_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Ignore;
            newMessageBox.Close();
        }

        static void btnCancel_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Cancel;
            newMessageBox.Close();
        }

        static void btnYes_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Yes;
            newMessageBox.Close();
        }

        static void btnNo_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.No;
            newMessageBox.Close();
        }

        static private void ShowOKButton()
        {
            btnOK = new ButtonX();
            btnOK.Text = "确定";
            btnOK.Size = new System.Drawing.Size(80, 25);
            btnOK.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            //btnOK.Anchor = AnchorStyles.Left;
            btnOK.Click += new EventHandler(btnOK_Click);
            flpButtons.Controls.Add(btnOK);
        }

        static private void ShowAbortButton()
        {
            btnAbort = new ButtonX();
            btnAbort.Text = "Abort";
            btnAbort.Size = new System.Drawing.Size(80, 25);
            btnAbort.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnAbort.Click += new EventHandler(btnAbort_Click);
            flpButtons.Controls.Add(btnAbort);
        }

        static private void ShowRetryButton()
        {
            btnRetry = new ButtonX();
            btnRetry.Text = "重试";
            btnRetry.Size = new System.Drawing.Size(80, 25);
            btnRetry.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnRetry.Click += new EventHandler(btnRetry_Click);
            flpButtons.Controls.Add(btnRetry);
        }

        static private void ShowIgnoreButton()
        {
            btnIgnore = new ButtonX();
            btnIgnore.Text = "忽略";
            btnIgnore.Size = new System.Drawing.Size(80, 25);
            btnIgnore.Click += new EventHandler(btnIgnore_Click);
            flpButtons.Controls.Add(btnIgnore);
        }

        static private void ShowCancelButton()
        {
            btnCancel = new ButtonX();
            btnCancel.Text = "取消";
            btnCancel.Size = new System.Drawing.Size(80, 25);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            flpButtons.Controls.Add(btnCancel);
        }

        static private void ShowYesButton()
        {
            btnYes = new ButtonX();
            btnYes.Text = "是";
            btnYes.Size = new System.Drawing.Size(80, 25);
            btnYes.Click += new EventHandler(btnYes_Click);
            flpButtons.Controls.Add(btnYes);
        }

        static private void ShowNoButton()
        {
            btnNo = new ButtonX();
            btnNo.Text = "否";
            btnNo.Size = new System.Drawing.Size(80, 25);
            btnNo.Click += new EventHandler(btnNo_Click);
            flpButtons.Controls.Add(btnNo);
        }

        static private void ButtonStatements(MyButtons MButtons)
        {
            if (MButtons == MyButtons.AbortRetryIgnore)
            {
                ShowIgnoreButton();
                ShowRetryButton();
                ShowAbortButton();
            }

            if (MButtons == MyButtons.OK)
            {
                ShowOKButton();
            }

            if (MButtons == MyButtons.OKCancel)
            {
                ShowCancelButton();
                ShowOKButton();
            }

            if (MButtons == MyButtons.RetryCancel)
            {
                ShowCancelButton();
                ShowRetryButton();
            }

            if (MButtons == MyButtons.YesNo)
            {
                ShowNoButton();
                ShowYesButton();
            }

            if (MButtons == MyButtons.YesNoCancel)
            {
                ShowCancelButton();
                ShowNoButton();
                ShowYesButton();
            }
        }

        static private void IconStatements()
        {
            if(largeIcon[221] != IntPtr.Zero)
            {
                frmIcon = Icon.FromHandle(largeIcon[221]);
            }
            
            /*
            if (MIcon == MyIcon.Error && largeIcon[109] != IntPtr.Zero)
            {
                MessageBeep(30);

            
                frmIcon = Icon.FromHandle(largeIcon[109]);
                
            }

            if (MIcon == MyIcon.Explorer && largeIcon[220] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[220]);
            }

            if (MIcon == MyIcon.Find && largeIcon[22] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[22]);
            }

            if (MIcon == MyIcon.Information && largeIcon[221] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[221]);

            }

            if (MIcon == MyIcon.Mail && largeIcon[156] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[156]);
            }

            if (MIcon == MyIcon.Media && largeIcon[116] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[116]);
            }

            if (MIcon == MyIcon.Print && largeIcon[136] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[136]);
            }

            if (MIcon == MyIcon.Question && largeIcon[23] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[23]);
            }

            if (MIcon == MyIcon.RecycleBinEmpty && largeIcon[31] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[31]);
            }

            if (MIcon == MyIcon.RecycleBinFull && largeIcon[32] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[32]);
            }

            if (MIcon == MyIcon.Stop && largeIcon[27] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[27]);
            }

            if (MIcon == MyIcon.User && largeIcon[170] != IntPtr.Zero)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[170]);
            }

            if (MIcon == MyIcon.Warning && largeIcon[217] != IntPtr.Zero)
            {
                MessageBeep(30);
                frmIcon = Icon.FromHandle(largeIcon[217]);
            }
            */
        }

        static void newMessageBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle frmTitleL = new Rectangle(0, 0, (newMessageBox.Width / 2), 22);
            Rectangle frmTitleR = new Rectangle((newMessageBox.Width / 2), 0, (newMessageBox.Width / 2), 22);
            Rectangle frmMessageBox = new Rectangle(0, 0, (newMessageBox.Width - 1), (newMessageBox.Height - 1));
            LinearGradientBrush frmLGBL = new LinearGradientBrush(frmTitleL, Color.FromArgb(87, 148, 160), Color.FromArgb(209, 230, 243), LinearGradientMode.Horizontal);
            LinearGradientBrush frmLGBR = new LinearGradientBrush(frmTitleR, Color.FromArgb(209, 230, 243), Color.FromArgb(87, 148, 160), LinearGradientMode.Horizontal);
            Pen frmPen = new Pen(Color.FromArgb(63, 119, 143), 1);
            g.FillRectangle(frmLGBL, frmTitleL);
            g.FillRectangle(frmLGBR, frmTitleR);
            g.DrawRectangle(frmPen, frmMessageBox);
        }
    }
}
