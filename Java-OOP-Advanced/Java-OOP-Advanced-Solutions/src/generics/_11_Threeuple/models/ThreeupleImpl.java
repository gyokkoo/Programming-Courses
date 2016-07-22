package generics._11_Threeuple.models;

import generics._11_Threeuple.interfaces.Threeuple;

public class ThreeupleImpl<T1, T2, T3> extends TupleImpl<T1, T2> implements Threeuple<T1, T2, T3> {

    private T3 item3;

    public ThreeupleImpl(T1 item1, T2 item2, T3 item3) {
        super(item1, item2);
        this.setItem3(item3);
    }

    @Override
    public T3 getItem3() {
        return this.item3;
    }

    @Override
    public void setItem3(T3 item3) {
        this.item3 = item3;
    }

    @Override
    public String toString() {
        return String.format("%s -> %s ",
                super.toString(), this.getItem3());
    }
}