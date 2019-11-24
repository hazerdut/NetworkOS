using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using Gma.System.MouseKeyHook;

namespace Demo
{
    public partial class Main : Form
    {
        private IKeyboardMouseEvents m_Events;
        public ChromiumWebBrowser wb;

        public Main()
        {
            InitializeComponent();
            SubscribeGlobal();
            FormClosing += Main_Closing;
            InitBrowser();
            InitializeComponentSuggest();
        }

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            wb = new ChromiumWebBrowser("maienglish.edu.vn/damang/");
            pnlweb.Controls.Add(wb);
            wb.Dock = DockStyle.Fill;
        }


        private void Main_Closing(object sender, CancelEventArgs e)
        {
            Unsubscribe();
        }


        private void SubscribeGlobal()
        {
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;
            m_Events.KeyDown += OnKeyDown;
            m_Events.KeyUp += OnKeyUp;
            m_Events.KeyPress += HookManager_KeyPress;

            m_Events.MouseUp += OnMouseUp;
            m_Events.MouseClick += OnMouseClick;
            m_Events.MouseDoubleClick += OnMouseDoubleClick;

            m_Events.MouseMove += HookManager_MouseMove;

            m_Events.MouseDragStarted += OnMouseDragStarted;
            m_Events.MouseDragFinished += OnMouseDragFinished;

        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;
            m_Events.KeyDown -= OnKeyDown;
            m_Events.KeyUp -= OnKeyUp;
            m_Events.KeyPress -= HookManager_KeyPress;

            m_Events.MouseUp -= OnMouseUp;
            m_Events.MouseClick -= OnMouseClick;
            m_Events.MouseDoubleClick -= OnMouseDoubleClick;

            m_Events.MouseMove -= HookManager_MouseMove;

            m_Events.MouseDragStarted -= OnMouseDragStarted;
            m_Events.MouseDragFinished -= OnMouseDragFinished;

           
            m_Events.Dispose();
            m_Events = null;
        }

        public async void Translate()
        {
            string rs = null;
            textBoxLog.Clear();
            SendKeys.SendWait("^(c)");
            async Task Puttaskdelay()
            {
                await Task.Delay(50);
            }

            await Puttaskdelay();
            string input = Clipboard.GetText();
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                rs = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", input, "", "vi");
                Log(input);
            }
            catch (Exception ex)
            {
                Log(input);
            }
        }

        private void HookManager_Supress(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                Log(string.Format("MouseDown \t\t {0}\n", e.Button));
                return;
            }

            Log(string.Format("MouseDown \t\t {0} Suppressed\n", e.Button));
            e.Handled = true;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            /*Log(string.Format("KeyDown  \t\t {0}\n", e.KeyCode));*/
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            /*Log(string.Format("KeyUp  \t\t {0}\n", e.KeyCode));*/
        }

        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Log(string.Format("KeyPress \t\t {0}\n", e.KeyChar));*/
        }

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            /*Log(string.Format("MouseDown \t\t {0}\n", e.Button));*/
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            /*Log(string.Format("MouseUp \t\t {0}\n", e.Button));*/
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            /*Log(string.Format("MouseClick \t\t {0}\n", e.Button));*/
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Copy();
            Translate();
            /*Log(string.Format("MouseDoubleClick \t\t {0}\n", e.Button));*/
        }

        private void OnMouseDragStarted(object sender, MouseEventArgs e)
        {
            /*Log("MouseDragStarted\n");*/
        }

        private void OnMouseDragFinished(object sender, MouseEventArgs e)
        {
            Copy();
            Translate();
            /*Log("MouseDragFinished\n");*/
        }


        private void Log(string text)
        {
            if (IsDisposed) return;
            textBoxLog.AppendText(text);
            textBoxLog.ScrollToCaret();
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            textBoxLog.Clear();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            String url = txt_url.Text;
            wb.Load(url);
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMousePosition_Click(object sender, EventArgs e)
        {

        }


        #region Editor and General

        private void Document_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            charCount.Text = "Characters in the current document: " + Document.TextLength.ToString();

            status_ZoomFactor.Text = Document.ZoomFactor.ToString();
        }



        #endregion



        #region MainMenu

        //FILE

        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }


        // EDIT MENU

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();

        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void edit_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        //TOOLS MENU

        private void tools_Customise_Click(object sender, EventArgs e)
        {
            customise();
        }

        #endregion



        #region Toolbar

        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_ZoomIn_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 63)
            {

                return;

            }
            else
                Document.ZoomFactor = Document.ZoomFactor + 1;
        }

        private void tb_ZoomOut_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 1)
            {

                return;


            }
            else
                Document.ZoomFactor = Document.ZoomFactor - 1;
        }


        private void tb_AlignLeft_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tb_AlignCenter_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tb_AlignRight_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tb_UpperCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToUpper();
        }

        private void tb_LowerCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToLower();
        }


        #endregion


        #region contextmenu

        private void rc_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void rc_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void rc_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void rc_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void rc_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        #endregion


        /* ALL CODE BELOW HERE!  */
        #region Methods

        #region file

        void New()
        {

            Document.Clear();
        }


        void Open()
        {
            if (openWork.ShowDialog() == DialogResult.OK)
            {
                Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
            }
        }



        void Save()
        {

            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        void Exit()
        {
            Application.Exit();
        }



        #endregion


        #region edit

        void Undo()
        {
            Document.Undo();
        }

        void Redo()
        {
            Document.Redo();
        }

        void Cut()
        {
            Document.Cut();
        }

        void Copy()
        {
            Document.Copy();
        }

        void Paste()
        {
            Document.Paste();
        }

        void SelectAll()
        {
            Document.SelectAll();
        }

        void ClearAll()
        {
            Document.Clear();
        }



        #endregion


        #region tools

        void customise()
        {
           

        }







        #endregion

        #endregion

        private void mM_File_Click(object sender, EventArgs e)
        {

        }

        private void tb_Copy_Click_1(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Cut_Click_1(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Paste_Click_1(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_Save_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Open_Click_1(object sender, EventArgs e)
        {
            Open();
        }
    }
}