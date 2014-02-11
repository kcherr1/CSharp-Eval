using System.Drawing;
using System.Text;



#pragma warning disable 0414

namespace CSE.Content {
	internal class IdentifierTest {
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
		public Vector3 vector3FieldTest;
		public StringBuilder strBuilderFieldTest;
		public int @if;
		public int @this;

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
		public StringBuilder strBuilderPropertyTest { get; set; }
		public int @If { get; set; }

		public IdentifierTest() {
			boolFieldTest = true;
			byteFieldTest = 50;
			charFieldTest = 'x';
			decimalFieldTest = 3.14156m;
			doubleFieldTest = 5.12345d;
			floatFieldTest = 2.345f;
			intFieldTest = -2309;
			longFieldTest = 89302L;
			sbyteFieldTest = -100;
			shortFieldTest = 10;
			stringFieldTest = "Hello World";
			uintFieldTest = 78u;
			ulongFieldTest = 928ul;
			ushortFieldTest = 23;
			colorFieldTest = Color.Blue;
			vector3FieldTest = new Vector3(1f, 2f, 3f);
			strBuilderFieldTest = new StringBuilder("Init");
			@if = 3;
			@this = 3;

			boolPropertyTest = true;
			bytePropertyTest = 50;
			charPropertyTest = 'x';
			decimalPropertyTest = 3.14156m;
			doublePropertyTest = 5.12345d;
			floatPropertyTest = 2.345f;
			intPropertyTest = -2309;
			longPropertyTest = 89302L;
			sbytePropertyTest = -100;
			shortPropertyTest = 10;
			stringPropertyTest = "Hello World";
			uintPropertyTest = 78u;
			ulongPropertyTest = 928ul;
			ushortPropertyTest = 23;
			colorPropertyTest = Color.Blue;
			vector3PropertyTest = new Vector3(1f, 2f, 3f);
			strBuilderPropertyTest = new StringBuilder("Init");
			@If = 3;
		}
	}
}
