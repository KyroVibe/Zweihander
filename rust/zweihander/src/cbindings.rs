#[no_mangle]
pub extern "C" fn test(num: i32) {
    println!("{}", num);
}
