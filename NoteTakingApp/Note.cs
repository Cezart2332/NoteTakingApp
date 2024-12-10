namespace NoteTakingApp
{
    public class Note
    {
        private string title;
        private string text;
        private byte[] image;
        
        
        
        public Note(string title, string text, byte[] image)
        {
            this.text = text;
            this.title = title;
            this.image = image;

        }
        public string GetTitle()
        {
            return this.title;
        }

        public string GetText()
        {
            return this.text;
        }
        public byte[] GetImage()
        {
            return this.image;
        }
        
        
    }
}