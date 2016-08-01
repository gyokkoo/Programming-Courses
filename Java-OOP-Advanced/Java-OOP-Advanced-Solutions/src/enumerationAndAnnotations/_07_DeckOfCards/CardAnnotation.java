package enumerationAndAnnotations._07_DeckOfCards;

import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

@Target(ElementType.TYPE)
@Retention(RetentionPolicy.RUNTIME)
public @interface CardAnnotation {

    String type();

    String category();

    String description();
}
