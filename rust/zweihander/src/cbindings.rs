use crate::example;

#[no_mangle]
pub extern "C" fn test(num: i32) {
    println!("{}", num);
}

#[no_mangle]
pub extern "C" fn rapier_example() {
    example::rapier_example();
}
