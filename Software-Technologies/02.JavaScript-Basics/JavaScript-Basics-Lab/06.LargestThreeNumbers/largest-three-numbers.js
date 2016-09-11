function largestThreeNumbers(arr) {
    let nums = arr.map(Number);
    nums.sort((a, b) => b - a);

    let count = Math.min(3, nums.length);
    for (let i = 0; i < count; i++) {
        console.log(nums[i]);
    }
}

largestThreeNumbers(['10', '30', '15', '20', '50', '5']);
largestThreeNumbers(['100', '-3', '20', '30']);
largestThreeNumbers(['100']);