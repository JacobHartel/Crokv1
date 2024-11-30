namespace Crokv1
{
    public class TrayIconApplication : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip contextMenu;


        //tray icon app opening with context menu items
        public TrayIconApplication()
        {
            trayIcon = new NotifyIcon();

            contextMenu = new ContextMenuStrip();

            ToolStripMenuItem settingsMenuItem = new ToolStripMenuItem("Settings");
            settingsMenuItem.Click += new EventHandler(OpenSettings);

            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += new EventHandler(Exit);

            //adding item to context menu
            contextMenu.Items.AddRange(new ToolStripMenuItem[]{
                
                settingsMenuItem,
                exitMenuItem
            });

            trayIcon.Icon = SystemIcons.Application;
            trayIcon.Text = "My Tray App";
            trayIcon.ContextMenuStrip = contextMenu;
            trayIcon.Visible = true;

            trayIcon.DoubleClick += new EventHandler(OpenApp);

        }

        private void OpenApp(object sender, EventArgs e)
        {
            //showing the app
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            //showing the settings
            Form1 settings = new Form1();
            settings.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            //I'm done, I can't do this anymore babe, I don't love you anymore....
            Application.Exit();
        }


    }
}