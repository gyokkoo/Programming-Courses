package generics._11_Threeuple.interfaces;

public interface Threeuple<T1, T2, T3> extends Tuple<T1, T2> {

    T3 getItem3();

    void setItem3(T3 item3);
}
