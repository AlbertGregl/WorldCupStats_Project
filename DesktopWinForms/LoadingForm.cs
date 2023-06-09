﻿using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWinForms
{
    public partial class LoadingForm : Form
    {
        public Action Worker { get; set; }

        public LoadingForm(Action worker)
        {
            InitializeComponent();

            if (worker == null)
            {
                throw new ArgumentNullException();
            }

            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Task.Factory.StartNew(Worker).ContinueWith(task =>
            {
                this.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
