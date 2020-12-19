
namespace SCPSLServerInfoEditor
{
    partial class SCPSLServerInfoEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCPSLServerInfoEditor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aquacyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkblueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuchsiamagentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightblueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oliveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomColorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.sizeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.cutToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator2,
            this.boldToolStripButton,
            this.italicToolStripButton,
            this.underlineToolStripButton,
            this.toolStripDropDownButton1,
            this.sizeToolStripTextBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources._new;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.save;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.copy;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.cut;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.paste;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.undo;
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoToolStripButton.Text = "Undo";
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.redo;
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redoToolStripButton.Text = "Redo";
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldToolStripButton.Text = "B";
            this.boldToolStripButton.ToolTipText = "Bold";
            this.boldToolStripButton.Click += new System.EventHandler(this.boldToolStripButton_Click);
            // 
            // italicToolStripButton
            // 
            this.italicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripButton.Name = "italicToolStripButton";
            this.italicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.italicToolStripButton.Text = "I";
            this.italicToolStripButton.ToolTipText = "Italic";
            this.italicToolStripButton.Click += new System.EventHandler(this.italicToolStripButton_Click);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineToolStripButton.Image = global::SCPSLServerInfoEditor.Properties.Resources.underline;
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineToolStripButton.Text = "U";
            this.underlineToolStripButton.ToolTipText = "Underline";
            this.underlineToolStripButton.Click += new System.EventHandler(this.underlineToolStripButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aquacyanToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.darkblueToolStripMenuItem,
            this.fuchsiamagentaToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.lightblueToolStripMenuItem,
            this.limeToolStripMenuItem,
            this.navyToolStripMenuItem,
            this.oliveToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.redToolStripMenuItem,
            this.silverToolStripMenuItem,
            this.tealToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.CustomColorToolStripTextBox});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(28, 22);
            this.toolStripDropDownButton1.Text = "A";
            // 
            // aquacyanToolStripMenuItem
            // 
            this.aquacyanToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.cyan;
            this.aquacyanToolStripMenuItem.Name = "aquacyanToolStripMenuItem";
            this.aquacyanToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aquacyanToolStripMenuItem.Text = "aqua/cyan";
            this.aquacyanToolStripMenuItem.Click += new System.EventHandler(this.aquacyanToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.black;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.blackToolStripMenuItem.Text = "black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.blueToolStripMenuItem.Text = "blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.brown;
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.brownToolStripMenuItem.Text = "brown";
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
            // 
            // darkblueToolStripMenuItem
            // 
            this.darkblueToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.darkblue;
            this.darkblueToolStripMenuItem.Name = "darkblueToolStripMenuItem";
            this.darkblueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.darkblueToolStripMenuItem.Text = "darkblue";
            this.darkblueToolStripMenuItem.Click += new System.EventHandler(this.darkblueToolStripMenuItem_Click);
            // 
            // fuchsiamagentaToolStripMenuItem
            // 
            this.fuchsiamagentaToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.magenta;
            this.fuchsiamagentaToolStripMenuItem.Name = "fuchsiamagentaToolStripMenuItem";
            this.fuchsiamagentaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fuchsiamagentaToolStripMenuItem.Text = "fuchsia/magenta";
            this.fuchsiamagentaToolStripMenuItem.Click += new System.EventHandler(this.fuchsiamagentaToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.greenToolStripMenuItem.Text = "green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.grey;
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.greyToolStripMenuItem.Text = "grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // lightblueToolStripMenuItem
            // 
            this.lightblueToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.lightblue;
            this.lightblueToolStripMenuItem.Name = "lightblueToolStripMenuItem";
            this.lightblueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.lightblueToolStripMenuItem.Text = "lightblue";
            this.lightblueToolStripMenuItem.Click += new System.EventHandler(this.lightblueToolStripMenuItem_Click);
            // 
            // limeToolStripMenuItem
            // 
            this.limeToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.lime;
            this.limeToolStripMenuItem.Name = "limeToolStripMenuItem";
            this.limeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.limeToolStripMenuItem.Text = "lime";
            this.limeToolStripMenuItem.Click += new System.EventHandler(this.limeToolStripMenuItem_Click);
            // 
            // navyToolStripMenuItem
            // 
            this.navyToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.navy;
            this.navyToolStripMenuItem.Name = "navyToolStripMenuItem";
            this.navyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.navyToolStripMenuItem.Text = "navy";
            this.navyToolStripMenuItem.Click += new System.EventHandler(this.navyToolStripMenuItem_Click);
            // 
            // oliveToolStripMenuItem
            // 
            this.oliveToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.olive;
            this.oliveToolStripMenuItem.Name = "oliveToolStripMenuItem";
            this.oliveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.oliveToolStripMenuItem.Text = "olive";
            this.oliveToolStripMenuItem.Click += new System.EventHandler(this.oliveToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.orange;
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orangeToolStripMenuItem.Text = "orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.purple;
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.purpleToolStripMenuItem.Text = "purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redToolStripMenuItem.Text = "red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // silverToolStripMenuItem
            // 
            this.silverToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.silver;
            this.silverToolStripMenuItem.Name = "silverToolStripMenuItem";
            this.silverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.silverToolStripMenuItem.Text = "silver";
            this.silverToolStripMenuItem.Click += new System.EventHandler(this.silverToolStripMenuItem_Click);
            // 
            // tealToolStripMenuItem
            // 
            this.tealToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.teal;
            this.tealToolStripMenuItem.Name = "tealToolStripMenuItem";
            this.tealToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tealToolStripMenuItem.Text = "teal";
            this.tealToolStripMenuItem.Click += new System.EventHandler(this.tealToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.white;
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.whiteToolStripMenuItem.Text = "white";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Image = global::SCPSLServerInfoEditor.Properties.Resources.yellow;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yellowToolStripMenuItem.Text = "yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // CustomColorToolStripTextBox
            // 
            this.CustomColorToolStripTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CustomColorToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomColorToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomColorToolStripTextBox.MaxLength = 7;
            this.CustomColorToolStripTextBox.Name = "CustomColorToolStripTextBox";
            this.CustomColorToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.CustomColorToolStripTextBox.Text = "#";
            this.CustomColorToolStripTextBox.ToolTipText = "Custom Color";
            this.CustomColorToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomColorToolStripTextBox_KeyDown);
            // 
            // sizeToolStripTextBox
            // 
            this.sizeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sizeToolStripTextBox.Name = "sizeToolStripTextBox";
            this.sizeToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            this.sizeToolStripTextBox.Text = "Size";
            this.sizeToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeToolStripTextBox_KeyDown);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox.Location = new System.Drawing.Point(0, 25);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 425);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // SCPSLServerInfoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SCPSLServerInfoEditor";
            this.ShowIcon = false;
            this.Text = "SCP:SL Server Info Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem aquacyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkblueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuchsiamagentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightblueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oliveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox CustomColorToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox sizeToolStripTextBox;
    }
}

