
public class _05_HelloWorld {
	public static void main(String[] args) {
		String hello = "Hello";
		String world = "World";
		Object helloWorld = hello + " " + world;
		String helloWorldStr = (String)helloWorld;
		
		System.out.println(helloWorldStr);
	}
}
