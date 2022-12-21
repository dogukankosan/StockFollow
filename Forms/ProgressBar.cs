using System;
using System.Collections.Generic;

namespace StockFollow_Up.Forms
{
    public partial class ProgressBar : DevExpress.XtraEditors.XtraForm
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        internal int sendMailCount = default;
        internal byte totalMailCount = default;
        internal byte notMail = default;
        internal List<string> notCustomer = new();
        internal bool IsEnd = false;
        internal void EndProgressBar()
        {
            IsEnd = true;
            Text = "Mail Gönderme İşlemi Tamamlandı";
        }
        internal void ProgressBarPlus()
        {
            progressBar1.Maximum = totalMailCount;
            Lbl_SendMailCount.Text = sendMailCount + "/" + totalMailCount;
            progressBar1.Value = sendMailCount;
            Lbl_NotMail.Text = notMail.ToString();
            Lst_Customer.Items.AddRange(notCustomer.ToArray());
            notCustomer.Clear();
        }
        private void ProgressBar_Load(object sender, EventArgs e)
        {
            Text = "Mail Gönderme İşlemi Yapılıyor...";
            ProgressBarPlus();
        }
        private void ProgressBar_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (IsEnd)
                e.Cancel = false;
        }
    }
}