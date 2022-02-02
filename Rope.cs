//structure similar to http://ahmadsoft.org/source/xref/ropes-1.2.5/src/org/ahmadsoft/ropes/Rope.java
public interface Rope{

    int Length{get; }
    int Depth{get; }
    Rope Append(char c);

    Rope Append(string str);

    Rope Delete(int start, int end);

    int IndexOf(char ch, int fromIdx=0);

    int IndexOf(string str, int fromIdx=0);

    Rope Insert(string str, int offset);

    string ToString();

}