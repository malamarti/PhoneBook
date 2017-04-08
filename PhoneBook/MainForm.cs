﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class MainForm : Form
    {
        AddContact AddForm;
        ContactDetails ContactDetails;
        BirthdayAlert Birthday;
        Search Search;
        public MainForm() {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm = new AddContact();
            AddForm.ShowDialog();
            contactList.Items.Clear();

            foreach (var item in ComC.people) {
                contactList.Items.Add(item.FirstName + " " + item.LastName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contactList.SelectedIndex >= 0) {
                ComC.ContactIndex = contactList.SelectedIndex;
                contactList.Items.RemoveAt(ComC.ContactIndex);
                ComC.people.RemoveAt(ComC.ContactIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(contactList.SelectedIndex >= 0) {
                ComC.ContactIndex = contactList.SelectedIndex;
                ContactDetails = new ContactDetails();
                ContactDetails.ShowDialog();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search = new Search();
            Search.ShowDialog();

            if (ComC.Condition != "") {
                contactList.Items.Clear();

                foreach (var item in ComC.people.Where(x => x.FirstName == ComC.Condition)) {
                    contactList.Items.Add(item.FirstName + " " + item.LastName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactList.Items.Clear();

            foreach (var item in ComC.people) {
                contactList.Items.Add(item.FirstName +" "+ item.LastName);
            }
            foreach (var item in ComC.people) {
                if (item.BirthDate.Date.Month == DateTime.Today.Month && item.BirthDate.Date.Day == DateTime.Today.Day) {
                    Birthday = new BirthdayAlert(item);
                    Birthday.ShowDialog();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            avatar.ImageLocation = openFileDialog1.FileName;
            avatar.BackgroundImage = null;
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) {

            contactList.Items.Clear();

            foreach (var item in ComC.people) {
                contactList.Items.Add(item.FirstName + " " + item.LastName);

            }

            foreach (var item in ComC.people) {
                if(item.BirthDate.Date.Month == DateTime.Today.Month && item.BirthDate.Date.Day == DateTime.Today.Day) {
                    Birthday = new BirthdayAlert(item);
                    Birthday.ShowDialog();
                }
            }
        }
    }
}