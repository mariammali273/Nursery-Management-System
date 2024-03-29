﻿using System;

namespace Nursery_Management_System
{
    partial class adminLoggedIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLoggedIn));
            this.signOutButton = new System.Windows.Forms.Button();
            this.adminFeedbackButton = new System.Windows.Forms.Button();
            this.editDatabase = new System.Windows.Forms.Button();
            this.adminProfileButton = new System.Windows.Forms.Button();
            this.pendingRequests = new System.Windows.Forms.Button();
            this.analyticsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signOutButton.Image = ((System.Drawing.Image)(resources.GetObject("signOutButton.Image")));
            this.signOutButton.Location = new System.Drawing.Point(614, 270);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(307, 270);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // adminFeedbackButton
            // 
            this.adminFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(215)))));
            this.adminFeedbackButton.FlatAppearance.BorderSize = 0;
            this.adminFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminFeedbackButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.adminFeedbackButton.Image = ((System.Drawing.Image)(resources.GetObject("adminFeedbackButton.Image")));
            this.adminFeedbackButton.Location = new System.Drawing.Point(1, 270);
            this.adminFeedbackButton.Name = "adminFeedbackButton";
            this.adminFeedbackButton.Size = new System.Drawing.Size(307, 270);
            this.adminFeedbackButton.TabIndex = 4;
            this.adminFeedbackButton.Text = "Feedback";
            this.adminFeedbackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminFeedbackButton.UseVisualStyleBackColor = false;
            // 
            // editDatabase
            // 
            this.editDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.editDatabase.FlatAppearance.BorderSize = 0;
            this.editDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDatabase.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.editDatabase.Image = ((System.Drawing.Image)(resources.GetObject("editDatabase.Image")));
            this.editDatabase.Location = new System.Drawing.Point(614, 0);
            this.editDatabase.Name = "editDatabase";
            this.editDatabase.Size = new System.Drawing.Size(307, 270);
            this.editDatabase.TabIndex = 5;
            this.editDatabase.Text = "Edit Database";
            this.editDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editDatabase.UseVisualStyleBackColor = false;
            this.editDatabase.Click += new System.EventHandler(this.editDatabase_Click);
            // 
            // adminProfileButton
            // 
            this.adminProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.adminProfileButton.FlatAppearance.BorderSize = 0;
            this.adminProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProfileButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.adminProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("adminProfileButton.Image")));
            this.adminProfileButton.Location = new System.Drawing.Point(1, 0);
            this.adminProfileButton.Name = "adminProfileButton";
            this.adminProfileButton.Size = new System.Drawing.Size(307, 270);
            this.adminProfileButton.TabIndex = 1;
            this.adminProfileButton.Text = "Profile";
            this.adminProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminProfileButton.UseVisualStyleBackColor = false;
            this.adminProfileButton.Click += new System.EventHandler(this.adminProfileButton_Click);
            // 
            // pendingRequests
            // 
            this.pendingRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.pendingRequests.FlatAppearance.BorderSize = 0;
            this.pendingRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingRequests.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.pendingRequests.Image = ((System.Drawing.Image)(resources.GetObject("pendingRequests.Image")));
            this.pendingRequests.Location = new System.Drawing.Point(307, 270);
            this.pendingRequests.Name = "pendingRequests";
            this.pendingRequests.Size = new System.Drawing.Size(307, 270);
            this.pendingRequests.TabIndex = 5;
            this.pendingRequests.Text = "Pending Requests";
            this.pendingRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pendingRequests.UseVisualStyleBackColor = false;
            this.pendingRequests.Click += new System.EventHandler(this.pendingRequests_Click);
            // 
            // analyticsButton
            // 
            this.analyticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.analyticsButton.FlatAppearance.BorderSize = 0;
            this.analyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.analyticsButton.Location = new System.Drawing.Point(307, 0);
            this.analyticsButton.Name = "analyticsButton";
            this.analyticsButton.Size = new System.Drawing.Size(307, 270);
            this.analyticsButton.TabIndex = 2;
            this.analyticsButton.Text = "Analytics";
            this.analyticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.analyticsButton.UseVisualStyleBackColor = false;
            this.analyticsButton.Click += new System.EventHandler(this.analyticsButton_Click);
            // 
            // adminLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.pendingRequests);
            this.Controls.Add(this.analyticsButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.adminFeedbackButton);
            this.Controls.Add(this.editDatabase);
            this.Controls.Add(this.adminProfileButton);
            this.Name = "adminLoggedIn";
            this.Text = "Nursery Management System - Logged In as Admin";
            this.Load += new System.EventHandler(this.adminLoggedIn_Load);
            this.ResumeLayout(false);

        }

        private void analyticsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button adminFeedbackButton;
        private System.Windows.Forms.Button editDatabase;
        private System.Windows.Forms.Button adminProfileButton;
        private System.Windows.Forms.Button pendingRequests;
        private System.Windows.Forms.Button analyticsButton;
    }
}