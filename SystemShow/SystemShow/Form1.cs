using System;

namespace SystemShow
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cntMEMORY()
        {
            float fRAM = pMEMORY.NextValue();
            bunifuGauge1.Value = (int)fRAM;
        } //Count used Memory

        private void cntCPU()
        {
            float fCPU = pCPU.NextValue();
            bunifuGauge3.Value = (int)fCPU;
        } //Count used CPU

        private void cntRAM() //Count used RAM
        {
            float px = pRAM.NextValue();
            bunifuGauge2.Value = (int)px;
        }

        private void cntWRITE()
        {
            float fWRITE = pWRITE.NextValue();
            bunifuGauge4.Value = (int)fWRITE;
        } //Disc Write Time

        private void timer1_Tick(object sender, EventArgs e)
        {
            cntMEMORY();
            cntCPU();
            cntRAM();
            cntWRITE();
        } //Calling Methods

        private void label4_Click(object sender, EventArgs e) //Close Application(X)
        {
            this.Close();
        }
    }
}
