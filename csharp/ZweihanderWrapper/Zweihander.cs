using System;
using System.Runtime.InteropServices;

namespace ZweihanderWrapper {
    public static class Zweihander {
        [DllImport("zweihander.dll")]
        public static extern void test(int num);
    }
}
