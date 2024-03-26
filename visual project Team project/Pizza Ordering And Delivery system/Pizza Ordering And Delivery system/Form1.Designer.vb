<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numquantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbsmall = New System.Windows.Forms.RadioButton()
        Me.rdbmedium = New System.Windows.Forms.RadioButton()
        Me.rdblarge = New System.Windows.Forms.RadioButton()
        Me.rdbextralarge = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbpineapple = New System.Windows.Forms.RadioButton()
        Me.rdbpepperoni = New System.Windows.Forms.RadioButton()
        Me.rdbsausages = New System.Windows.Forms.RadioButton()
        Me.rdbcheese = New System.Windows.Forms.RadioButton()
        Me.rdbblackolives = New System.Windows.Forms.RadioButton()
        Me.rdbmushroom = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbhoneychipotlebbq = New System.Windows.Forms.RadioButton()
        Me.rdbgarlicmayonnaise = New System.Windows.Forms.RadioButton()
        Me.rdbspicymarinara = New System.Windows.Forms.RadioButton()
        Me.rdbhoneysrirachadrizzle = New System.Windows.Forms.RadioButton()
        Me.rdbsmokychipotlemayo = New System.Windows.Forms.RadioButton()
        Me.rdbscotchbonnetjam = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbsparklingwater = New System.Windows.Forms.RadioButton()
        Me.rdbsprite = New System.Windows.Forms.RadioButton()
        Me.rdbwater = New System.Windows.Forms.RadioButton()
        Me.rdbcoke = New System.Windows.Forms.RadioButton()
        Me.rdbkrest = New System.Windows.Forms.RadioButton()
        Me.rdbfantablackcurent = New System.Windows.Forms.RadioButton()
        Me.rdbfantaorange = New System.Windows.Forms.RadioButton()
        Me.rdbfantapassion = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstborderdetails = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.numquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(616, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Pizza"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.ForeColor = System.Drawing.Color.Gold
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cheese Pizza", "Veggie Pizza", "Pepperoni Pizza", "Meat Pizza", "Margherita Pizza", "BBQ Chicken Pizza", "Hawaiian Pizza", "Buffallo Pizza"})
        Me.ComboBox1.Location = New System.Drawing.Point(778, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(286, 29)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(952, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Display"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'numquantity
        '
        Me.numquantity.BackColor = System.Drawing.Color.Black
        Me.numquantity.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.numquantity.ForeColor = System.Drawing.Color.Gold
        Me.numquantity.Location = New System.Drawing.Point(802, 63)
        Me.numquantity.Name = "numquantity"
        Me.numquantity.Size = New System.Drawing.Size(67, 32)
        Me.numquantity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(616, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbsmall)
        Me.GroupBox1.Controls.Add(Me.rdbmedium)
        Me.GroupBox1.Controls.Add(Me.rdblarge)
        Me.GroupBox1.Controls.Add(Me.rdbextralarge)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(245, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 227)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prices"
        '
        'rdbsmall
        '
        Me.rdbsmall.AutoSize = True
        Me.rdbsmall.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbsmall.Location = New System.Drawing.Point(6, 196)
        Me.rdbsmall.Name = "rdbsmall"
        Me.rdbsmall.Size = New System.Drawing.Size(138, 25)
        Me.rdbsmall.TabIndex = 3
        Me.rdbsmall.TabStop = True
        Me.rdbsmall.Text = "Small ; 600"
        Me.rdbsmall.UseVisualStyleBackColor = True
        '
        'rdbmedium
        '
        Me.rdbmedium.AutoSize = True
        Me.rdbmedium.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbmedium.Location = New System.Drawing.Point(6, 150)
        Me.rdbmedium.Name = "rdbmedium"
        Me.rdbmedium.Size = New System.Drawing.Size(174, 25)
        Me.rdbmedium.TabIndex = 2
        Me.rdbmedium.TabStop = True
        Me.rdbmedium.Text = "Medium ; 1000"
        Me.rdbmedium.UseVisualStyleBackColor = True
        '
        'rdblarge
        '
        Me.rdblarge.AutoSize = True
        Me.rdblarge.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdblarge.Location = New System.Drawing.Point(6, 99)
        Me.rdblarge.Name = "rdblarge"
        Me.rdblarge.Size = New System.Drawing.Size(150, 25)
        Me.rdblarge.TabIndex = 1
        Me.rdblarge.TabStop = True
        Me.rdblarge.Text = " Large; 1400"
        Me.rdblarge.UseVisualStyleBackColor = True
        '
        'rdbextralarge
        '
        Me.rdbextralarge.AutoSize = True
        Me.rdbextralarge.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbextralarge.Location = New System.Drawing.Point(6, 45)
        Me.rdbextralarge.Name = "rdbextralarge"
        Me.rdbextralarge.Size = New System.Drawing.Size(205, 25)
        Me.rdbextralarge.TabIndex = 0
        Me.rdbextralarge.TabStop = True
        Me.rdbextralarge.Text = "Extra Large; 1800"
        Me.rdbextralarge.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbpineapple)
        Me.GroupBox2.Controls.Add(Me.rdbpepperoni)
        Me.GroupBox2.Controls.Add(Me.rdbsausages)
        Me.GroupBox2.Controls.Add(Me.rdbcheese)
        Me.GroupBox2.Controls.Add(Me.rdbblackolives)
        Me.GroupBox2.Controls.Add(Me.rdbmushroom)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(550, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 227)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Extra Toppings"
        '
        'rdbpineapple
        '
        Me.rdbpineapple.AutoSize = True
        Me.rdbpineapple.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbpineapple.Location = New System.Drawing.Point(9, 41)
        Me.rdbpineapple.Name = "rdbpineapple"
        Me.rdbpineapple.Size = New System.Drawing.Size(129, 25)
        Me.rdbpineapple.TabIndex = 6
        Me.rdbpineapple.TabStop = True
        Me.rdbpineapple.Text = "Pineapple"
        Me.rdbpineapple.UseVisualStyleBackColor = True
        '
        'rdbpepperoni
        '
        Me.rdbpepperoni.AutoSize = True
        Me.rdbpepperoni.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbpepperoni.Location = New System.Drawing.Point(6, 72)
        Me.rdbpepperoni.Name = "rdbpepperoni"
        Me.rdbpepperoni.Size = New System.Drawing.Size(131, 25)
        Me.rdbpepperoni.TabIndex = 5
        Me.rdbpepperoni.TabStop = True
        Me.rdbpepperoni.Text = "Pepperoni"
        Me.rdbpepperoni.UseVisualStyleBackColor = True
        '
        'rdbsausages
        '
        Me.rdbsausages.AutoSize = True
        Me.rdbsausages.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbsausages.Location = New System.Drawing.Point(9, 196)
        Me.rdbsausages.Name = "rdbsausages"
        Me.rdbsausages.Size = New System.Drawing.Size(118, 25)
        Me.rdbsausages.TabIndex = 4
        Me.rdbsausages.TabStop = True
        Me.rdbsausages.Text = "Sausages"
        Me.rdbsausages.UseVisualStyleBackColor = True
        '
        'rdbcheese
        '
        Me.rdbcheese.AutoSize = True
        Me.rdbcheese.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbcheese.Location = New System.Drawing.Point(6, 165)
        Me.rdbcheese.Name = "rdbcheese"
        Me.rdbcheese.Size = New System.Drawing.Size(97, 25)
        Me.rdbcheese.TabIndex = 3
        Me.rdbcheese.TabStop = True
        Me.rdbcheese.Text = "Cheese"
        Me.rdbcheese.UseVisualStyleBackColor = True
        '
        'rdbblackolives
        '
        Me.rdbblackolives.AutoSize = True
        Me.rdbblackolives.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbblackolives.Location = New System.Drawing.Point(6, 134)
        Me.rdbblackolives.Name = "rdbblackolives"
        Me.rdbblackolives.Size = New System.Drawing.Size(143, 25)
        Me.rdbblackolives.TabIndex = 2
        Me.rdbblackolives.TabStop = True
        Me.rdbblackolives.Text = "Black Olive"
        Me.rdbblackolives.UseVisualStyleBackColor = True
        '
        'rdbmushroom
        '
        Me.rdbmushroom.AutoSize = True
        Me.rdbmushroom.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbmushroom.Location = New System.Drawing.Point(6, 103)
        Me.rdbmushroom.Name = "rdbmushroom"
        Me.rdbmushroom.Size = New System.Drawing.Size(134, 25)
        Me.rdbmushroom.TabIndex = 1
        Me.rdbmushroom.TabStop = True
        Me.rdbmushroom.Text = "Mushroom"
        Me.rdbmushroom.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdbhoneychipotlebbq)
        Me.GroupBox3.Controls.Add(Me.rdbgarlicmayonnaise)
        Me.GroupBox3.Controls.Add(Me.rdbspicymarinara)
        Me.GroupBox3.Controls.Add(Me.rdbhoneysrirachadrizzle)
        Me.GroupBox3.Controls.Add(Me.rdbsmokychipotlemayo)
        Me.GroupBox3.Controls.Add(Me.rdbscotchbonnetjam)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(850, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 227)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dipping Sauces"
        '
        'rdbhoneychipotlebbq
        '
        Me.rdbhoneychipotlebbq.AutoSize = True
        Me.rdbhoneychipotlebbq.BackColor = System.Drawing.Color.Transparent
        Me.rdbhoneychipotlebbq.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbhoneychipotlebbq.Location = New System.Drawing.Point(6, 41)
        Me.rdbhoneychipotlebbq.Name = "rdbhoneychipotlebbq"
        Me.rdbhoneychipotlebbq.Size = New System.Drawing.Size(226, 25)
        Me.rdbhoneychipotlebbq.TabIndex = 6
        Me.rdbhoneychipotlebbq.TabStop = True
        Me.rdbhoneychipotlebbq.Text = "Honey Chipotle BBQ"
        Me.rdbhoneychipotlebbq.UseVisualStyleBackColor = False
        '
        'rdbgarlicmayonnaise
        '
        Me.rdbgarlicmayonnaise.AutoSize = True
        Me.rdbgarlicmayonnaise.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbgarlicmayonnaise.Location = New System.Drawing.Point(6, 72)
        Me.rdbgarlicmayonnaise.Name = "rdbgarlicmayonnaise"
        Me.rdbgarlicmayonnaise.Size = New System.Drawing.Size(214, 25)
        Me.rdbgarlicmayonnaise.TabIndex = 5
        Me.rdbgarlicmayonnaise.TabStop = True
        Me.rdbgarlicmayonnaise.Text = "Garlic Mayonnaise"
        Me.rdbgarlicmayonnaise.UseVisualStyleBackColor = True
        '
        'rdbspicymarinara
        '
        Me.rdbspicymarinara.AutoSize = True
        Me.rdbspicymarinara.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbspicymarinara.Location = New System.Drawing.Point(6, 196)
        Me.rdbspicymarinara.Name = "rdbspicymarinara"
        Me.rdbspicymarinara.Size = New System.Drawing.Size(187, 25)
        Me.rdbspicymarinara.TabIndex = 4
        Me.rdbspicymarinara.TabStop = True
        Me.rdbspicymarinara.Text = "Spicy Marinara"
        Me.rdbspicymarinara.UseVisualStyleBackColor = True
        '
        'rdbhoneysrirachadrizzle
        '
        Me.rdbhoneysrirachadrizzle.AutoSize = True
        Me.rdbhoneysrirachadrizzle.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbhoneysrirachadrizzle.Location = New System.Drawing.Point(6, 165)
        Me.rdbhoneysrirachadrizzle.Name = "rdbhoneysrirachadrizzle"
        Me.rdbhoneysrirachadrizzle.Size = New System.Drawing.Size(263, 25)
        Me.rdbhoneysrirachadrizzle.TabIndex = 3
        Me.rdbhoneysrirachadrizzle.TabStop = True
        Me.rdbhoneysrirachadrizzle.Text = "Honey Sriracha Drizzle"
        Me.rdbhoneysrirachadrizzle.UseVisualStyleBackColor = True
        '
        'rdbsmokychipotlemayo
        '
        Me.rdbsmokychipotlemayo.AutoSize = True
        Me.rdbsmokychipotlemayo.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbsmokychipotlemayo.Location = New System.Drawing.Point(6, 134)
        Me.rdbsmokychipotlemayo.Name = "rdbsmokychipotlemayo"
        Me.rdbsmokychipotlemayo.Size = New System.Drawing.Size(248, 25)
        Me.rdbsmokychipotlemayo.TabIndex = 2
        Me.rdbsmokychipotlemayo.TabStop = True
        Me.rdbsmokychipotlemayo.Text = "Smocky Chipotle Mayo"
        Me.rdbsmokychipotlemayo.UseVisualStyleBackColor = True
        '
        'rdbscotchbonnetjam
        '
        Me.rdbscotchbonnetjam.AutoSize = True
        Me.rdbscotchbonnetjam.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbscotchbonnetjam.Location = New System.Drawing.Point(6, 103)
        Me.rdbscotchbonnetjam.Name = "rdbscotchbonnetjam"
        Me.rdbscotchbonnetjam.Size = New System.Drawing.Size(212, 25)
        Me.rdbscotchbonnetjam.TabIndex = 1
        Me.rdbscotchbonnetjam.TabStop = True
        Me.rdbscotchbonnetjam.Text = "Scotch Bonnet Jam"
        Me.rdbscotchbonnetjam.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rdbsparklingwater)
        Me.GroupBox4.Controls.Add(Me.rdbsprite)
        Me.GroupBox4.Controls.Add(Me.rdbwater)
        Me.GroupBox4.Controls.Add(Me.rdbcoke)
        Me.GroupBox4.Controls.Add(Me.rdbkrest)
        Me.GroupBox4.Controls.Add(Me.rdbfantablackcurent)
        Me.GroupBox4.Controls.Add(Me.rdbfantaorange)
        Me.GroupBox4.Controls.Add(Me.rdbfantapassion)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox4.Location = New System.Drawing.Point(550, 349)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(271, 279)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Drinks"
        '
        'rdbsparklingwater
        '
        Me.rdbsparklingwater.AutoSize = True
        Me.rdbsparklingwater.BackColor = System.Drawing.Color.Transparent
        Me.rdbsparklingwater.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbsparklingwater.Location = New System.Drawing.Point(6, 245)
        Me.rdbsparklingwater.Name = "rdbsparklingwater"
        Me.rdbsparklingwater.Size = New System.Drawing.Size(198, 25)
        Me.rdbsparklingwater.TabIndex = 8
        Me.rdbsparklingwater.TabStop = True
        Me.rdbsparklingwater.Text = " Sparkling Water"
        Me.rdbsparklingwater.UseVisualStyleBackColor = False
        '
        'rdbsprite
        '
        Me.rdbsprite.AutoSize = True
        Me.rdbsprite.BackColor = System.Drawing.Color.Transparent
        Me.rdbsprite.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbsprite.Location = New System.Drawing.Point(6, 214)
        Me.rdbsprite.Name = "rdbsprite"
        Me.rdbsprite.Size = New System.Drawing.Size(92, 25)
        Me.rdbsprite.TabIndex = 7
        Me.rdbsprite.TabStop = True
        Me.rdbsprite.Text = "Sprite"
        Me.rdbsprite.UseVisualStyleBackColor = False
        '
        'rdbwater
        '
        Me.rdbwater.AutoSize = True
        Me.rdbwater.BackColor = System.Drawing.Color.Transparent
        Me.rdbwater.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbwater.Location = New System.Drawing.Point(6, 28)
        Me.rdbwater.Name = "rdbwater"
        Me.rdbwater.Size = New System.Drawing.Size(101, 25)
        Me.rdbwater.TabIndex = 6
        Me.rdbwater.TabStop = True
        Me.rdbwater.Text = " Water"
        Me.rdbwater.UseVisualStyleBackColor = False
        '
        'rdbcoke
        '
        Me.rdbcoke.AutoSize = True
        Me.rdbcoke.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbcoke.Location = New System.Drawing.Point(6, 59)
        Me.rdbcoke.Name = "rdbcoke"
        Me.rdbcoke.Size = New System.Drawing.Size(78, 25)
        Me.rdbcoke.TabIndex = 5
        Me.rdbcoke.TabStop = True
        Me.rdbcoke.Text = "Coke"
        Me.rdbcoke.UseVisualStyleBackColor = True
        '
        'rdbkrest
        '
        Me.rdbkrest.AutoSize = True
        Me.rdbkrest.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbkrest.Location = New System.Drawing.Point(6, 183)
        Me.rdbkrest.Name = "rdbkrest"
        Me.rdbkrest.Size = New System.Drawing.Size(88, 25)
        Me.rdbkrest.TabIndex = 4
        Me.rdbkrest.TabStop = True
        Me.rdbkrest.Text = "Krest"
        Me.rdbkrest.UseVisualStyleBackColor = True
        '
        'rdbfantablackcurent
        '
        Me.rdbfantablackcurent.AutoSize = True
        Me.rdbfantablackcurent.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbfantablackcurent.Location = New System.Drawing.Point(6, 152)
        Me.rdbfantablackcurent.Name = "rdbfantablackcurent"
        Me.rdbfantablackcurent.Size = New System.Drawing.Size(223, 25)
        Me.rdbfantablackcurent.TabIndex = 3
        Me.rdbfantablackcurent.TabStop = True
        Me.rdbfantablackcurent.Text = "Fanta Blackcurrent"
        Me.rdbfantablackcurent.UseVisualStyleBackColor = True
        '
        'rdbfantaorange
        '
        Me.rdbfantaorange.AutoSize = True
        Me.rdbfantaorange.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbfantaorange.Location = New System.Drawing.Point(6, 121)
        Me.rdbfantaorange.Name = "rdbfantaorange"
        Me.rdbfantaorange.Size = New System.Drawing.Size(167, 25)
        Me.rdbfantaorange.TabIndex = 2
        Me.rdbfantaorange.TabStop = True
        Me.rdbfantaorange.Text = "Fanta Orange"
        Me.rdbfantaorange.UseVisualStyleBackColor = True
        '
        'rdbfantapassion
        '
        Me.rdbfantapassion.AutoSize = True
        Me.rdbfantapassion.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rdbfantapassion.Location = New System.Drawing.Point(6, 90)
        Me.rdbfantapassion.Name = "rdbfantapassion"
        Me.rdbfantapassion.Size = New System.Drawing.Size(168, 25)
        Me.rdbfantapassion.TabIndex = 1
        Me.rdbfantapassion.TabStop = True
        Me.rdbfantapassion.Text = "Fanta Passion"
        Me.rdbfantapassion.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(245, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Display Order"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(245, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 34)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Order Total"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lstborderdetails
        '
        Me.lstborderdetails.BackColor = System.Drawing.Color.Black
        Me.lstborderdetails.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstborderdetails.ForeColor = System.Drawing.Color.Gold
        Me.lstborderdetails.FormattingEnabled = True
        Me.lstborderdetails.ItemHeight = 21
        Me.lstborderdetails.Location = New System.Drawing.Point(850, 350)
        Me.lstborderdetails.Name = "lstborderdetails"
        Me.lstborderdetails.Size = New System.Drawing.Size(269, 277)
        Me.lstborderdetails.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(251, 492)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(260, 34)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1162, 709)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lstborderdetails)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numquantity)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents numquantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbsmall As RadioButton
    Friend WithEvents rdbmedium As RadioButton
    Friend WithEvents rdblarge As RadioButton
    Friend WithEvents rdbextralarge As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbpineapple As RadioButton
    Friend WithEvents rdbpepperoni As RadioButton
    Friend WithEvents rdbsausages As RadioButton
    Friend WithEvents rdbcheese As RadioButton
    Friend WithEvents rdbblackolives As RadioButton
    Friend WithEvents rdbmushroom As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbhoneychipotlebbq As RadioButton
    Friend WithEvents rdbgarlicmayonnaise As RadioButton
    Friend WithEvents rdbspicymarinara As RadioButton
    Friend WithEvents rdbhoneysrirachadrizzle As RadioButton
    Friend WithEvents rdbsmokychipotlemayo As RadioButton
    Friend WithEvents rdbscotchbonnetjam As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdbsparklingwater As RadioButton
    Friend WithEvents rdbsprite As RadioButton
    Friend WithEvents rdbwater As RadioButton
    Friend WithEvents rdbcoke As RadioButton
    Friend WithEvents rdbkrest As RadioButton
    Friend WithEvents rdbfantablackcurent As RadioButton
    Friend WithEvents rdbfantaorange As RadioButton
    Friend WithEvents rdbfantapassion As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lstborderdetails As ListBox
    Friend WithEvents Button5 As Button
End Class
