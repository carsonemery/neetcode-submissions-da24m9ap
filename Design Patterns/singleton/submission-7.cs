public class Singleton {

    private static Singleton UniqueInstance = null;
    private string value = null;

    private Singleton() {
      
    }

    public static Singleton getInstance() {
        if (UniqueInstance == null) {
            UniqueInstance = new Singleton();
        }

        return UniqueInstance;
    }

    public string getValue() {
        return value;
    }

    public void setValue(string value){
       this.value = value;
    }
}
