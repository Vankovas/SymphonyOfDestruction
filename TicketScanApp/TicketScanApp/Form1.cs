using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using Ozeki.Vision;
using Phidget22;
using Phidget22.Events;


namespace TicketScanApp
{
    public partial class TicketScanForm : Form
    {

        CameraURLBuilderWF _myCameraUrlBuilder;
        private IBarcodeReader _barcodeReader;
        private OzekiCamera _camera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;
        private ImageProcesserHandler _imageProcesserHandler;
        private FrameCapture _frameCapture;
        private List<int> _barcodesList;
        private int _counter;
        DBConnect myConnection;

        RFID rfid;



        void TicketScanForm_Load(object sender, EventArgs e)
        {

            _imageProvider = new DrawingImageProvider();
            _connector = new MediaConnector();
            _imageProcesserHandler = new ImageProcesserHandler();
            _frameCapture = new FrameCapture();
            _barcodeReader = ImageProcesserFactory.CreateBarcodeReader();
            _barcodesList = new List<int>();
            videoViewerWF1.SetImageProvider(_imageProvider);
            _myCameraUrlBuilder = new CameraURLBuilderWF();
            this.connectCamera();
            myConnection.OpenConnection();
            StartUp();

        }

        public TicketScanForm()
        {
            InitializeComponent();
            myConnection = new DBConnect();
        }

        /*private bool detectionOccured(BarcodeDetectedEventArgs e)
        {
            if (e.DetectedBarcode.Equals(true))
            {
                return true;
            }
            return false;
        }*/

        private void searchTicketId(bool n)
        {
            listBoxDetails.Items.Clear();

            if (myConnection.findUser(listBoxDetails.Items, textBox1.Text) == true)
            {
                tbTicketId.Text = textBox1.Text;
            }
            else { MessageBox.Show("This ticketID does not exist!"); }
        }

        private void connectCamera()
        {
            if (_camera != null)
            {
                //_camera.CameraStateChanged -= _camera_CameraStateChanged;
                _camera.Disconnect();
                _connector.Disconnect(_camera.VideoChannel, _imageProvider);
                _camera.Dispose();
                _camera = null;
            }

            string camUrl = "usb://DeviceId=0;Name=HD WebCam;";

            _camera = new OzekiCamera(_myCameraUrlBuilder.Text = camUrl);

            //_camera.CameraStateChanged += _camera_CameraStateChanged;

            //btnConnect.Enabled = false;

            _connector.Connect(_camera.VideoChannel, _imageProvider);
            videoViewerWF1.SetImageProvider(_imageProvider);

            _barcodeReader.DetectionOccurred += _barcodeReadercam_DetectionOccurred;

            _imageProcesserHandler.AddProcesser(_barcodeReader);

            _connector.Connect(_camera.VideoChannel, _imageProcesserHandler);

            _imageProcesserHandler.Start();

            videoViewerWF1.Start();

            _camera.Start();
        }

        private void disconnectCamera()
        {

            if (_camera == null) return;

            _connector.Disconnect(_camera.VideoChannel, _imageProvider);
            _camera.Disconnect();

            _camera = null;

        }

        public void StartUp()
        {
            try
            {
                rfid = new RFID();

                rfid.Attach += rfid_Attach;
                rfid.Detach += rfid_Detach;
                rfid.Error += rfid_Error;
                tbBraceletId.Text = "";
                rfid.Tag += rfid_Tag;
                rfid.TagLost += rfid_TagLost;

                rfid.Open();
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch
            {
                MessageBox.Show("something else");
            }
        }

        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            tbStatus.Text = "attached";
        }

        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            tbStatus.Text = "detached";
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("error");
        }

        private void rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            tbStatus.Text = e.Tag;
            string reg = e.Tag;
            tbBraceletId.Text = reg;
        }

        private void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            tbStatus.Text = "ready";
        }


        /*private void _camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
              if (e.State == CameraState.Connecting)
                     btnConnect.Enabled = false;
              if (e.State == CameraState.Streaming)
                     btnDisconnect.Enabled = true;
              if (e.State == CameraState.Disconnected)
                 {
                     btnDisconnect.Enabled = false;
                     btnConnect.Enabled = true;
              }
            }
            );
        }*/


        void _barcodeReadercam_DetectionOccurred(object sender, BarcodeDetectedEventArgs e)
        {
            InvokeGuiThread(() =>
            {

                if (e == null)
                return;

                //foreach (var barcode in _barcodesList)
                 //{
                if (e.DetectedBarcode.Equals(true))
                {
                    _barcodesList.Add(Convert.ToInt32(e.DetectedBarcode.Content));
                }
                //}

                _counter++;


                textBox1.Text = e.DetectedBarcode.Content.ToString();

                if (textBox1.ReadOnly == false && btnSearch.Enabled == true)
                {
                    textBox1.ReadOnly = true;
                    btnSearch.Enabled = false;
                }

                this.searchTicketId(true);


            }
            );
        }

        void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }


        /*private void btnCompose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK) return;

            //tbUrl.Text = _myCameraUrlBuilder.CameraURL;
            //btnConnect.Enabled = true;
        }*/

        private void TicketScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.CloseConnection();
            rfid.Close();
            this.disconnectCamera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myConnection.assignBracelet(tbBraceletId.Text, tbTicketId.Text) == true)
            {

                MessageBox.Show("BraceletID assigned successfully!");

                tbTicketId.Text = "";
                tbBraceletId.Text = "";
                listBoxDetails.Items.Clear();
                textBox1.Text = "";

                if (textBoxNewTicket.Text != "" || textBoxNewTicket.Text != null)
                {
                    textBoxNewTicket.Text = "";
                }

            }
            else { MessageBox.Show("Problem assigning braceletID!"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.searchTicketId(true);
        }

        private void btnManualInput_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            btnSearch.Enabled = true;
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            string days;

            if (checkBoxFriday.Checked == true && checkBoxSaturday.Checked == true && checkBoxSunday.Checked == true) { days = "15-07-2018 to 17-07-2018"; }
            else if (checkBoxFriday.Checked == true && checkBoxSaturday.Checked == true) { days = "15-07-2018 to 16-07-2018"; }
            else if (checkBoxSaturday.Checked == true && checkBoxSunday.Checked == true) { days = "16-07-2018 to 17-07-2018";  }
            else if (checkBoxFriday.Checked == true && checkBoxSunday.Checked == true)
            {
                days = "15-07-2018 and 17-07-2018";
            }
            else if (checkBoxFriday.Checked == true) { days = "15-07-2018"; }
            else if (checkBoxSaturday.Checked == true) { days = "16-07-2018"; }
            else { days = "17-07-2018"; }

            if (myConnection.buyTicket(tbFname.Text, tbLname.Text, tbEmail.Text, days) == true)
            {
                MessageBox.Show("Ticket bought successfully!");

                textBoxNewTicket.Text = myConnection.findTicket(tbEmail.Text);


                tbTicketId.Text = textBoxNewTicket.Text;


                tbFname.Text = "";
                tbLname.Text = "";
                tbEmail.Text = "";
                checkBoxFriday.Checked = true;
                checkBoxSaturday.Checked = true; 
                checkBoxSunday.Checked = true;
            }
            else { MessageBox.Show("Problem buying ticket!"); }


        }
    }
}

