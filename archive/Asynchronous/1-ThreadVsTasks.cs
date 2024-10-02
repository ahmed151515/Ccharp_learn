
namespace archive.Asynchronous
{
	public class ThreadVsTasks
	{
		// Why Task Over Thread?

		// | Criteria               | Thread          | Task            | Advantage                   |
		// |------------------------|-----------------|-----------------|-----------------------------|
		// | Concept                | Low-level       | Abstraction      | Less details                |
		// | Leveraging Thread Pool  | No              | Yes             | Performance                 |
		// | Return Value           | No              | Yes             | Less code                   |
		// | Chaining               | No              | Yes             | Order/Readability           |
		// | Exception Propagation  | No              | Yes             | Parent catch it             |
		// | Task Type              | Foreground/Background | Background | Process termination         |
		// | Support Cancellation   | No              | Yes             | Save resources              |

		/* Explanation:
		1. Concept:
		   - Threads operate at a low level, requiring more manual management of resources and synchronization.
		   - Tasks provide an abstraction that simplifies execution and error-prone details.

		2. Leveraging Thread Pool:
		   - Tasks automatically utilize thread pools, improving performance by reusing threads.
		   - Threads don’t have automatic thread pool integration.

		3. Return Value:
		   - Tasks can return values (e.g., Task<T> in C#), simplifying asynchronous code.
		   - Threads don't natively return values.

		4. Chaining:
		   - Tasks support chaining operations (e.g., ContinueWith()), improving readability and code structure.
		   - Threads do not natively support chaining.

		5. Exception Propagation:
		   - Tasks propagate exceptions to the parent, making error handling easier.
		   - Threads require manual intervention for exception handling.

		6. Task Type:
		   - Tasks run in the background, allowing the main process to continue uninterrupted.
		   - Threads can be foreground or background depending on the setup.

		7. Support Cancellation:
		   - Tasks support cancellation, allowing resource-efficient task termination.
		   - Threads do not natively support cancellation, potentially leading to wasted resources.
		*/

		public static void Main()
		{

			//Task.Run(
			//			() => Display("hi my name ahmed")
			//	).Wait();

		}


		private static void Display(string msg)
		{
			ShowThreadInfo(Thread.CurrentThread);
			Console.WriteLine(msg);
		}

		public static void ShowThreadInfo(Thread Th = null)
		{
			if (Th is null)
			{
				Th = Thread.CurrentThread;
			}
			Console.WriteLine($"Thread Info: ID = {Th.ManagedThreadId}," +
				$" Pooled = {Th.IsThreadPoolThread}, Background = {Th.IsBackground}");
		}
	}
}
