using System.Drawing;
using TriggersTools.SteinsGate;

static void make_divergence(string text)
{
    int margin = -9;
    var divergenceArgs = new DivergenceArgs
    {
        Scale = DivergenceScale.Large,
        Spacing = new DivergenceSpacing(margin, margin),
        // Background = Color.FromArgb(224, 224, 224),
    };

    string path = @"meter";
    Directory.CreateDirectory(path);
    using (Bitmap bmp = Divergence.Draw(text, divergenceArgs))
        bmp.Save(path + "/" + text + ".png");
}
for (int i=0; i<10; i++)
{
    make_divergence(i.ToString());
}
make_divergence(".");
make_divergence("-");
make_divergence(" ");
