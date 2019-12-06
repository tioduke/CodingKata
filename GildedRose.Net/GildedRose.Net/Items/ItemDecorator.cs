namespace GildedRose.Net.Items
{
    public abstract class ItemDecorator
    {

        // Constants
        protected const int MIN_QUALITY = 0;
        protected const int MAX_QUALITY = 50;
    
        // Members
        private Item itemToDecorate;

        // Constructors
        protected ItemDecorator(Item itemToDecorate)
        {
            this.itemToDecorate = itemToDecorate;
        }
        
        // Properties
        public string Name
        {
            get
            {
                return this.itemToDecorate.Name;
            }
            set
            {
                this.itemToDecorate.Name = value;
            }
        }
        
        public int SellIn
        {
            get
            {
                return this.itemToDecorate.SellIn;
            }
            set
            {
                this.itemToDecorate.SellIn = value;
            }
        }
        
        public int Quality
        {
            get
            {
                return this.itemToDecorate.Quality;
            }
            set
            {
                this.itemToDecorate.Quality = value;
            }
        }
    
        // Read-only properties
        protected bool SellInEnded
        {
            get {
                return this.SellIn <= 0;
            }
        }
        
        protected bool SellInEvenNumber
        {
            get {
                return this.SellIn % 2 == 0;
            }
        }
        
        protected bool SellInOddNumber
        {
            get {
                return this.SellIn % 2 != 0;
            }
        }
        
        // Public methods
        public void Update()
        {
            this.UpdateQuality();
            this.UpdateSellIn();
        }
        
        // Protected methods
        protected abstract void UpdateQuality();
        
        protected virtual void UpdateSellIn()
        {
            this.SellIn--;
        }
        
        protected void DecreaseQualityOnce()
        {
            this.Quality -= 1;
            if (this.Quality < MIN_QUALITY) this.Quality = MIN_QUALITY;
        }
        
        protected void DecreaseQualityTwice()
        {
            this.Quality -= 2;
            if (this.Quality < MIN_QUALITY) this.Quality = MIN_QUALITY;
        }
        
        protected void DecreaseQualityQuarce()
        {
            this.Quality -= 4;
            if (this.Quality < MIN_QUALITY) this.Quality = MIN_QUALITY;
        }
        
        protected void IncreaseQualityOnce()
        {
            this.Quality += 1;
            if (this.Quality > MAX_QUALITY) this.Quality = MAX_QUALITY;
        }
        
        protected void IncreaseQualityTwice()
        {
            this.Quality += 2;
            if (this.Quality > MAX_QUALITY) this.Quality = MAX_QUALITY;
        }
        
        protected void IncreaseQualityThrice()
        {
            this.Quality += 3;
            if (this.Quality > MAX_QUALITY) this.Quality = MAX_QUALITY;
        }

    }
}