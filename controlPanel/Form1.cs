namespace controlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> s = new List<string>();
        public void addS()
        {
            s.Add(new string("Administrative Tools"));
            s.Add(new string("AutoPlay"));
            s.Add(new string("Backup and Restore(Windows 7)"));
            s.Add(new string("BitLocker Drive Encryption"));
            s.Add(new string("Color Management"));
            s.Add(new string("Credential Manager"));
            s.Add(new string("Date and Time"));
            s.Add(new string("Default Programs"));
            s.Add(new string("Decive Manager"));
            s.Add(new string("Devices and Printers"));
            s.Add(new string("Ease Of Access Center"));

            s.Add(new string("File Explorer Options"));
            s.Add(new string("File History"));
            s.Add(new string("Fonts"));
            s.Add(new string("Indexing Options "));
            s.Add(new string("Infrared"));
            s.Add(new string("Intel (R) COmpuetr Improvement Program"));
            s.Add(new string("Internet Options"));
            s.Add(new string("Java"));
            s.Add(new string("Keyboard"));
            s.Add(new string("Mail (Microsoft Outlook)(32-bit)"));

            s.Add(new string("Mouse"));
            s.Add(new string("Network and Sharing Center"));
            s.Add(new string("Phone and Moden"));
            s.Add(new string("Power Options"));
            s.Add(new string("Program and Features"));
            s.Add(new string("Recovery"));
            s.Add(new string("Region"));
            s.Add(new string("RemoteApp and Desktop Connections"));
            s.Add(new string("Security and Manteinance"));
            s.Add(new string("SiSoftware Sandra"));

            s.Add(new string("Sounds"));
            s.Add(new string("Speech Recognition"));
            s.Add(new string("Storage Spaces"));
            s.Add(new string("Sync Center"));
            s.Add(new string("System"));
            s.Add(new string("Taskbar and Navigation"));
            s.Add(new string("Troubleshooting"));
            s.Add(new string("User Accounts"));
            s.Add(new string("Windows Defender Firewall"));
            s.Add(new string("Windows Mobility Center"));

            s.Add(new string("Work Folder"));

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}