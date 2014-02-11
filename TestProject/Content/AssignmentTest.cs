using System.Drawing;
using System.Text;



#pragma warning disable 0169

namespace CSE.Content {
	internal class AssignmentTest {
		public bool boolFieldTest;
		public byte byteFieldTest;
		public char charFieldTest;
		public decimal decimalFieldTest;
		public double doubleFieldTest;
		public float floatFieldTest;
		public int intFieldTest;
		public long longFieldTest;
		public sbyte sbyteFieldTest;
		public short shortFieldTest;
		public string stringFieldTest;
		public uint uintFieldTest;
		public ulong ulongFieldTest;
		public ushort ushortFieldTest;
		public Color colorFieldTest;
		public Vector3 vector3FieldTest = new Vector3(4, 7, 9);
		public B bFieldTest = new B();
		public StringBuilder sbFieldTest;
		public double[] doubleArrayFieldTest;
		public int[] intArrayFieldTest;

		public bool boolPropertyTest { get; set; }
		public byte bytePropertyTest { get; set; }
		public char charPropertyTest { get; set; }
		public decimal decimalPropertyTest { get; set; }
		public double doublePropertyTest { get; set; }
		public float floatPropertyTest { get; set; }
		public int intPropertyTest { get; set; }
		public long longPropertyTest { get; set; }
		public sbyte sbytePropertyTest { get; set; }
		public short shortPropertyTest { get; set; }
		public string stringPropertyTest { get; set; }
		public uint uintPropertyTest { get; set; }
		public ulong ulongPropertyTest { get; set; }
		public ushort ushortPropertyTest { get; set; }
		public Color colorPropertyTest { get; set; }
		public Vector3 vector3PropertyTest { get; set; }
		public B bPropertyTest { get; set; }
		public StringBuilder sbPropertyTest { get; set; }
		public double[] doubleArrayPropertyTest { get; set; }
		public Vector3[] vector3ArrayPropertyTest { get; set; }

		public AssignmentTest() {
			intArrayFieldTest = new int[] { 3, 8, 9, 5, 19, 20 };
			doubleArrayPropertyTest = new double[] { 1.0, 4.21, 3.1415, 9.25, .7, .00001 };
			doubleArrayFieldTest = new double[] { 1.0, 4.21, 3.1415, 9.25, .7, .00001 };
			vector3ArrayPropertyTest = new Vector3[] {
				new Vector3(1, 2, 3),
				new Vector3(4, 5, 6),
				new Vector3(7, 8, 9)
			};
			bPropertyTest = new B();

			byteFieldTest = 2;
			decimalFieldTest = 2;
			doubleFieldTest = 2;
			floatFieldTest = 2;
			intFieldTest = 2;
			longFieldTest = 2;
			sbyteFieldTest = 2;
			shortFieldTest = 2;
			uintFieldTest = 2;
			ulongFieldTest = 2;
			ushortFieldTest = 2;

			bytePropertyTest = 32;
			intPropertyTest = 34;
			longPropertyTest = 78;
		}
	}
}
