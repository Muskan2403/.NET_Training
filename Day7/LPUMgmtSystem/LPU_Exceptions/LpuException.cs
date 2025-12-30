namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception Class Created For LPU Project
    /// By Muskan on Date 29/12/2025 at 11:35AM
    /// </summary>
    public class LpuException:Exception
    {
        public LpuException():base()            //constructor chaining
        {
            
        }

        public LpuException(string errorMsg):base(errorMsg)
        {
            
        }
    }
}
