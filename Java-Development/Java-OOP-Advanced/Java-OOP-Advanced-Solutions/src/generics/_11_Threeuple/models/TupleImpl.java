package generics._11_Threeuple.models;

import generics._11_Threeuple.interfaces.Tuple;

public class TupleImpl<T1, T2> implements Tuple<T1, T2> {

    private T1 item1;
    private T2 item2;

    public TupleImpl(T1 item1, T2 item2) {
        this.setItem1(item1);
        this.setItem2(item2);
    }

    @Override
    public T1 getItem1() {
        return this.item1;
    }

    @Override
    public void setItem1(T1 item1) {
        this.item1 = item1;
    }

    @Override
    public T2 getItem2() {
        return this.item2;
    }

    @Override
    public void setItem2(T2 item2) {
        this.item2 = item2;
    }

    @Override
    public String toString() {
        return String.format("%s -> %s", this.getItem1(), this.getItem2());
    }
}
