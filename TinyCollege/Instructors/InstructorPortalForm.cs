﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCollege.Utilities;

namespace TinyCollege.Instructors
{
    public partial class InstructorPortalForm : Form
    {
        private readonly ModelRepository _repo;

        public InstructorPortalForm(ModelRepository repo)
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InstructorPortalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
