using System;
using System.Drawing;
using System.Windows.Forms;

ApplicationConfiguration.Initialize();

var form = new Form
{
    Text = "HO SONN zZz | SENSI MENU",
    Size = new Size(850, 550),
    StartPosition = FormStartPosition.CenterScreen,
    BackColor = Color.FromArgb(13, 18, 30),
    ForeColor = Color.White
};

var title = new Label
{
    Text = "HO SONN zZz",
    Font = new Font("Segoe UI", 22, FontStyle.Bold),
    ForeColor = Color.FromArgb(50, 230, 200),
    Location = new Point(30, 25),
    AutoSize = true
};
form.Controls.Add(title);

var menu = new Panel
{
    Location = new Point(25, 95),
    Size = new Size(210, 390),
    BackColor = Color.FromArgb(25, 35, 53)
};
form.Controls.Add(menu);

var content = new Label
{
    Text = "WELCOME TO HO SONN MENU",
    Font = new Font("Segoe UI", 18, FontStyle.Bold),
    Location = new Point(275, 130),
    AutoSize = true,
    ForeColor = Color.White
};
form.Controls.Add(content);

string[] names =
{
    "HOME", "MOUSE FIX", "SENSITIVITY",
    "EMULATOR", "SETTINGS"
};

int y = 20;

foreach (string name in names)
{
    var button = new Button
    {
        Text = name,
        Location = new Point(15, y),
        Size = new Size(180, 50),
        FlatStyle = FlatStyle.Flat,
        BackColor = Color.FromArgb(35, 52, 75),
        ForeColor = Color.White,
        Font = new Font("Segoe UI", 10, FontStyle.Bold)
    };

    button.FlatAppearance.BorderColor =
        Color.FromArgb(50, 210, 190);

    button.Click += (s, e) =>
        content.Text = name;

    menu.Controls.Add(button);
    y += 65;
}

form.Controls.Add(new Label
{
    Text = "BY HO SONN zZz",
    Location = new Point(600, 470),
    AutoSize = true,
    ForeColor = Color.FromArgb(50, 230, 200)
});

Application.Run(form);
