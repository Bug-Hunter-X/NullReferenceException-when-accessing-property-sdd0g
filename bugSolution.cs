public class MyClass {
    public int? MyProperty { get; set; }

    public void MyMethod() {
        // Use the null-conditional operator to safely access the property.
        int? value = MyProperty?.GetHashCode();

        // Or use null-coalescing assignment to provide a default value
        int valueOrDefault = MyProperty ?? 0;
        int anotherValueOrDefault = MyProperty?.GetHashCode() ?? 0;
    }
}