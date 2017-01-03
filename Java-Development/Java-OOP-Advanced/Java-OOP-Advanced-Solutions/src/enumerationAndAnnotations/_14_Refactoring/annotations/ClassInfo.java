package enumerationAndAnnotations._14_Refactoring.annotations;

import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

@Target(ElementType.TYPE)
@Retention(RetentionPolicy.RUNTIME)
public @interface ClassInfo {

    String author();

    int revision();

    String description();

    String[] reviewers();
}
