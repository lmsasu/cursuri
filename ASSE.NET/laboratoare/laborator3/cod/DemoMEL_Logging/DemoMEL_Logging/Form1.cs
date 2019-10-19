using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMEL_Logging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Logger.IsLoggingEnabled())
            {
                LogEntry logEntry = new LogEntry()
                {
                    EventId = 100,
                    Priority = 2,
                    Message = "mesaj de informare",
                    Severity = System.Diagnostics.TraceEventType.Information
                };
                logEntry.Categories.Add("Trace");
                logEntry.Categories.Add("UI Events");

                logEntry.ExtendedProperties["locatie"] = this.GetType().ToString();

                Logger.Write(logEntry);
            }

        }
    }
}
