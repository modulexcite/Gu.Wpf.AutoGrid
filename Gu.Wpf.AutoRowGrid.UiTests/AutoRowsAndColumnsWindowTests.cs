namespace Gu.Wpf.AutoRowGrid.UiTests
{
    using NUnit.Framework;

    public class AutoRowsAndColumnsTests : WindowTest
    {
        public override string Title { get; } = "AutoRowsAndColumnsWindow";

        [Test]
        public void Bounds()
        {
            Assert.AreEqual("0,0 29,18", this.Window.GetTextBoxPosition("R0C0"));
            Assert.AreEqual("29,0 150,18", this.Window.GetTextBoxPosition("R0C1"));
            Assert.AreEqual("0,18 29,36", this.Window.GetTextBoxPosition("R1C0"));
            Assert.AreEqual("29,18 150,36", this.Window.GetTextBoxPosition("R1C1"));
        }
    }
}