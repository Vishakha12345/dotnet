namespace CollegeLib
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public override string ToString()
        {
            string details = string.Empty;
            details = Title + " " + Author + " " + Publication;
            return details;
        }
    }
}

// What are important methods of object class

//o public bool Equals(object)-----comparision
//o protected void Finalize()------Deinitialize
//o public int GetHashCode()------hashcode
//o public System.Type GetType()---reflection
//o protected object MemberwiseClone()--shallow copy
//o public string ToString() --- represent string


