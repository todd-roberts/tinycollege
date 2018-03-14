﻿using System;
using System.Windows.Forms;
using TinyCollege.Students;
using TinyCollege.Instructors;
using TinyCollege.Admins;
using TinyCollege.Models;
using System.Collections.Generic;
using TinyCollege.Utilities;

namespace TinyCollege
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminPortalForm form = new AdminPortalForm();
            form.ShowDialog();
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {
            InstructorPortalForm form = new InstructorPortalForm();
            form.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentPortalForm form = new StudentPortalForm();
            form.ShowDialog();
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Instructor> instructorList = Data.GetInstructors();
        }
    }
}
