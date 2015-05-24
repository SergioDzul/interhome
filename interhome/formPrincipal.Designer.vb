<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ClientesInternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesInternetToolStripMenuItem, Me.ClientesVentaToolStripMenuItem, Me.CatalogoDeProductosToolStripMenuItem, Me.CajaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(784, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'ClientesInternetToolStripMenuItem
        '
        Me.ClientesInternetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.AdminDePagosToolStripMenuItem})
        Me.ClientesInternetToolStripMenuItem.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ClientesInternetToolStripMenuItem.Name = "ClientesInternetToolStripMenuItem"
        Me.ClientesInternetToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ClientesInternetToolStripMenuItem.Text = "Clientes Internet"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'AdminDePagosToolStripMenuItem
        '
        Me.AdminDePagosToolStripMenuItem.Name = "AdminDePagosToolStripMenuItem"
        Me.AdminDePagosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AdminDePagosToolStripMenuItem.Text = "Admin de pagos"
        '
        'ClientesVentaToolStripMenuItem
        '
        Me.ClientesVentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem1, Me.CotizacionesToolStripMenuItem})
        Me.ClientesVentaToolStripMenuItem.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ClientesVentaToolStripMenuItem.Name = "ClientesVentaToolStripMenuItem"
        Me.ClientesVentaToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ClientesVentaToolStripMenuItem.Text = "Clientes venta"
        '
        'VerToolStripMenuItem1
        '
        Me.VerToolStripMenuItem1.Name = "VerToolStripMenuItem1"
        Me.VerToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VerToolStripMenuItem1.Text = "Ver"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'CatalogoDeProductosToolStripMenuItem
        '
        Me.CatalogoDeProductosToolStripMenuItem.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CatalogoDeProductosToolStripMenuItem.Name = "CatalogoDeProductosToolStripMenuItem"
        Me.CatalogoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(158, 20)
        Me.CatalogoDeProductosToolStripMenuItem.Text = "Catalogo de productos"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.interhome.My.Resources.Resources._7601351058d8c14768bc183bd367566c1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 450)
        Me.Controls.Add(Me.menuPrincipal)
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "formPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesInternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminDePagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
