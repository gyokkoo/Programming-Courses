package generics._10_Tuple.interfaces;

public interface Tuple<T1, T2> {

    T1 getItem1();

    void setItem1(T1 item1);

    T2 getItem2();

    void setItem2(T2 item2);
}