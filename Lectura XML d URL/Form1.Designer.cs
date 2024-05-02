
namespace Lectura_XML_d_URL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listViewXMLData = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.info = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewXMLData
            // 
            this.listViewXMLData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewXMLData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.info});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewXMLData.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewXMLData.HideSelection = false;
            this.listViewXMLData.Location = new System.Drawing.Point(15, 15);
            this.listViewXMLData.Margin = new System.Windows.Forms.Padding(6);
            this.listViewXMLData.Name = "listViewXMLData";
            this.listViewXMLData.Size = new System.Drawing.Size(676, 354);
            this.listViewXMLData.TabIndex = 1;
            this.listViewXMLData.UseCompatibleStateImageBehavior = false;
            this.listViewXMLData.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // info
            // 
            this.info.Tag = "info";
            this.info.Text = "Info";
            this.info.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.listViewXMLData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewXMLData;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader info;
    }
}

