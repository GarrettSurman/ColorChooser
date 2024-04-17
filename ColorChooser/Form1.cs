namespace ColorChooser
{
    public partial class Form1 : Form
    {

        private Random rnd = new Random();
        Color MyColor = new Color();
        Color MyColorInv = new Color();
       
        int myRed = 0;
        int myBlue = 0;
        int myGreen = 0;



        public Form1()
        {
            InitializeComponent();

        }
        public void updateFormValues()
        {


            MyColor = Color.FromArgb(myRed, myBlue, myGreen);
            panel1.BackColor = MyColor;


            lblRedNumber.Text = myRed.ToString();
            lblGreenNumber.Text = myGreen.ToString();
            lblBlueNumber.Text = myBlue.ToString();
            trackBarRed.Value = myRed;  
            trackBarGreen.Value = myGreen;  
            trackBarBlue.Value = myBlue;    

            Color invertedColor = Color.FromArgb(MyColor.ToArgb() ^ 0xffffff);
            //skew colors for label so not to end of with hard to see color. 
            // differnt from inverse cuz 128.128.128 is the same this causes that never to happen
            if (invertedColor.R > 110 && invertedColor.R < 150 &&
                invertedColor.G > 110 && invertedColor.G < 150 &&
                invertedColor.B > 110 && invertedColor.B < 150)
            {
                int avg = (invertedColor.R + invertedColor.G + invertedColor.B) / 3;
                avg = avg > 128 ? 200 : 60;
                invertedColor = Color.FromArgb(avg, avg, avg);
            }

            myColorLabel.ForeColor = invertedColor;
            myColorLabel.Text = MyColor.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {

         myRed = rnd.Next(256);
         myBlue = rnd.Next(256);
         myGreen = rnd.Next(256);

         MyColor = Color.FromArgb(myRed, myBlue, myGreen);

         updateFormValues();  
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            myRed = trackBarRed.Value;
            updateFormValues();    
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            myGreen = trackBarGreen.Value;
            updateFormValues(); 
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {

            myBlue = trackBarBlue.Value;
            updateFormValues();

        }
    }
}
