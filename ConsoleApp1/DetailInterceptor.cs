using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class DetailInterceptor()
    {
        [InterceptsLocation(@"C:\code\whats-new-c-sharp-12\ConsoleApp1\Program.cs", line: 41, character: 35)]
        public static string HijackedDetails(ref readonly Rocket rocket)
        {
            return "YOUR ROCKET HAS BEEN HIJACKED!!!";
        }
    }
}
