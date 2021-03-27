namespace MyFirstBlazorApp.Shared
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
    }
}