


#pragma warning disable 0414
#pragma warning disable 1591

using System.Drawing;
namespace CSE.Content {
	internal class MethodTest {
		bool publicVoidRan;
		bool protectedVoidRan;
		bool privateVoidRan;
		bool internalVoidRan;
		bool argTestValueTypesRan;
		bool argTestRefTypesRan;
		static bool staticVoidRan;
		bool virtualVoidRan;
		B bb;
		B bc;

		public object ReturnParam(object param) {
			return param;
		}

		public MethodTest() {
			publicVoidRan = false;
			protectedVoidRan = false;
			privateVoidRan = false;
			internalVoidRan = false;
			argTestValueTypesRan = false;
			argTestRefTypesRan = false;
			MethodTest.staticVoidRan = false;
			virtualVoidRan = false;
			bb = new B();
			bc = new C();
		}

		public bool ArgTestValueTypesRan {
			get {
				bool temp = argTestValueTypesRan;
				argTestValueTypesRan = false;
				return temp;
			}
		}

		public bool ArgTestRefTypesRan {
			get {
				bool temp = argTestRefTypesRan;
				argTestRefTypesRan = false;
				return temp;
			}
		}

		public void PublicVoid() {
			publicVoidRan = true;
		}
		protected void ProtectedVoid() {
			protectedVoidRan = true;
		}
		private void PrivateVoid() {
			privateVoidRan = true;
		}
		internal void InternalVoid() {
			internalVoidRan = true;
		}

		public void ArgTestValueTypes(string paramValues, bool boolParam, byte byteParam, char charParam, decimal decimalParam, double doubleParam,
									 float floatParam, int intParam, long longParam, sbyte sbyteParam, short shortParam, uint uintParam,
									 ulong ulongParam, ushort ushortParam) {
			string[] expectedParamValues = paramValues.Split(',');

			bool passed = true;
			if (boolParam != bool.Parse(expectedParamValues[0]))
				passed = false;
			if (byteParam != byte.Parse(expectedParamValues[1]))
				passed = false;
			if (charParam != char.Parse(expectedParamValues[2].Trim()))
				passed = false;
			if (decimalParam != decimal.Parse(expectedParamValues[3]))
				passed = false;
			if (doubleParam != double.Parse(expectedParamValues[4]))
				passed = false;
			if (floatParam != float.Parse(expectedParamValues[5]))
				passed = false;
			if (intParam != int.Parse(expectedParamValues[6]))
				passed = false;
			if (longParam != long.Parse(expectedParamValues[7]))
				passed = false;
			if (sbyteParam != sbyte.Parse(expectedParamValues[8]))
				passed = false;
			if (shortParam != short.Parse(expectedParamValues[9]))
				passed = false;
			if (uintParam != uint.Parse(expectedParamValues[10]))
				passed = false;
			if (ulongParam != ulong.Parse(expectedParamValues[11]))
				passed = false;
			if (ushortParam != ushort.Parse(expectedParamValues[12]))
				passed = false;

			argTestValueTypesRan = passed;
		}
		void ArgTestRefTypes(Color color, Vector3 vector3) {
			if (color != null)
				argTestRefTypesRan = true;
		}

		int NumericDiscreteReturn() {
			return 3;
		}
		float NumericRealReturn() {
			return 3.5f;
		}
		bool BoolReturn() {
			return true;
		}
		char CharReturn() {
			return 'x';
		}
		string StringReturn() {
			return "Hello World";
		}

		static void StaticVoid() {
			MethodTest.staticVoidRan = true;
		}
		static int StaticReturn() {
			return 3;
		}

		public virtual void VirtualVoid() {
			virtualVoidRan = true;
		}
		public virtual int VirtualReturn() {
			return 3;
		}

		public string OverloadedMeth(float f) {
			return "float";
		}
		public string OverloadedMeth(double d) {
			return "double";
		}
		public string OverloadedMeth(decimal m) {
			return "decimal";
		}
		public string OverloadedMeth(byte b) {
			return "byte";
		}
		public string OverloadedMeth(short s) {
			return "short";
		}
		public string OverloadedMeth(int i) {
			return "int";
		}
		public string OverloadedMeth(long l) {
			return "long";
		}
		public string OverloadedMeth(B b) {
			return "B";
		}
		public string OverloadedMeth(C c) {
			return "C";
		}
		//public string OverloadedMeth(byte b, int i) {
		//    return "byte,int";
		//}
		public string OverloadedMeth(int i, byte b) {
			return "int,byte";
		}
		public string OverloadedMeth(byte i, byte b) {
			return "byte,byte";
		}

		public B BCMeth() {
			return new C();
		}

		public void SByteMeth(sbyte sb) {
		}

		public void ByteMeth(byte b) {
		}

		public void ShortMeth(short s) {
		}

		public void IntMeth(int i) {
		}

		public void LongMeth(long l) {
		}

		public string OverloadedIntMeth(short s) {
			return "short";
		}
		public string OverloadedIntMeth(byte b) {
			return "byte";
		}
		public string OverloadedIntMeth(long l) {
			return "long";
		}
	}
}
