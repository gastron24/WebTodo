namespace Todo.Models
{
    public class StatusLevel
    {
        public static readonly int[] percent = { };

        
        
        public int numInArray(int num)
        {            
            for(int i = 0; i< 100; i++)
            {
                percent[i] = num;
            }          
          return percent.Length;      // привязать к задаче (статус выполнения задачи)
        }
        
        
    }
}
