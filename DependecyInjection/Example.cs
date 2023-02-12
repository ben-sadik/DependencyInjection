#region
public interface IProductService
{
	void DoSomething();
}
public class ProductService : IProductService
{
	public void DoSomething() {}
}
#endregion
public class Example
{
	public void Main()
	{
		ProductService productService = new ProductService();
		productService.DoSomething();
	}
}
