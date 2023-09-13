using System;
using System.Runtime.InteropServices;

namespace ZweihanderWrapper {
    public static class Zweihander {

        #if MACOS
        private const string LIB_PATH = "libzweihander.dylib";
        #else
        private const string LIB_PATH = "zweihander.dll";
        #endif

        [DllImport(LIB_PATH, EntryPoint = "test")]
        public static extern void test(int num);

        [DllImport(LIB_PATH, EntryPoint = "rapier_example")]
        public static extern void rapier_example();
    }
}
