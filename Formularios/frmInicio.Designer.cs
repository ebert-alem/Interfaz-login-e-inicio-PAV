namespace Clase_1_PAV
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuPpal = new System.Windows.Forms.Panel();
            this.panelBarrraSup = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.btnMaterias = new FontAwesome.Sharp.IconButton();
            this.btnPromedios = new FontAwesome.Sharp.IconButton();
            this.btnTareas = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelMenuPpal.SuspendLayout();
            this.panelBarrraSup.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.panelMenuPpal);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 608);
            this.panelMenu.TabIndex = 12;
            // 
            // panelMenuPpal
            // 
            this.panelMenuPpal.Controls.Add(this.btnMaterias);
            this.panelMenuPpal.Controls.Add(this.btnPromedios);
            this.panelMenuPpal.Controls.Add(this.btnTareas);
            this.panelMenuPpal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuPpal.Location = new System.Drawing.Point(0, 136);
            this.panelMenuPpal.Name = "panelMenuPpal";
            this.panelMenuPpal.Size = new System.Drawing.Size(200, 472);
            this.panelMenuPpal.TabIndex = 0;
            // 
            // panelBarrraSup
            // 
            this.panelBarrraSup.Controls.Add(this.panel1);
            this.panelBarrraSup.Controls.Add(this.picLogin);
            this.panelBarrraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarrraSup.Location = new System.Drawing.Point(200, 0);
            this.panelBarrraSup.Name = "panelBarrraSup";
            this.panelBarrraSup.Size = new System.Drawing.Size(793, 100);
            this.panelBarrraSup.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(637, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 97);
            this.panel1.TabIndex = 12;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(200, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(658, 508);
            this.panelPrincipal.TabIndex = 15;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnCerrarSesion);
            this.panelUsuario.Controls.Add(this.btnSalir);
            this.panelUsuario.Location = new System.Drawing.Point(856, 100);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(137, 76);
            this.panelUsuario.TabIndex = 2;
            this.panelUsuario.Visible = false;
            this.panelUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panelUsuario.MouseLeave += new System.EventHandler(this.panelUsuario_MouseLeave);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconSize = 20;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Rotation = 0D;
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 30);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconSize = 20;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(120, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(707, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(74, 67);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 11;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaterias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaterias.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMaterias.IconColor = System.Drawing.Color.White;
            this.btnMaterias.IconSize = 32;
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.Location = new System.Drawing.Point(0, 80);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Rotation = 0D;
            this.btnMaterias.Size = new System.Drawing.Size(200, 40);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterias.UseVisualStyleBackColor = false;
            // 
            // btnPromedios
            // 
            this.btnPromedios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromedios.FlatAppearance.BorderSize = 0;
            this.btnPromedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromedios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPromedios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromedios.IconChar = FontAwesome.Sharp.IconChar.SortNumericUpAlt;
            this.btnPromedios.IconColor = System.Drawing.Color.White;
            this.btnPromedios.IconSize = 32;
            this.btnPromedios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedios.Location = new System.Drawing.Point(0, 40);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Rotation = 0D;
            this.btnPromedios.Size = new System.Drawing.Size(200, 40);
            this.btnPromedios.TabIndex = 1;
            this.btnPromedios.Text = "Promedios";
            this.btnPromedios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromedios.UseVisualStyleBackColor = false;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTareas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTareas.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnTareas.IconColor = System.Drawing.Color.White;
            this.btnTareas.IconSize = 32;
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Location = new System.Drawing.Point(0, 0);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Rotation = 0D;
            this.btnTareas.Size = new System.Drawing.Size(200, 40);
            this.btnTareas.TabIndex = 0;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(993, 608);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelBarrraSup);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuPpal.ResumeLayout(false);
            this.panelBarrraSup.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuPpal;
        private System.Windows.Forms.Panel panelBarrraSup;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox picLogin;
        private FontAwesome.Sharp.IconButton btnTareas;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnMaterias;
        private FontAwesome.Sharp.IconButton btnPromedios;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}

