function numbersSequence(n, k) {
  let result = [1];

  for (let i = 1; i < n; i++) {
    let start = Math.max(0, i - k);
    let end = i - 1;
    result[i] = result.slice(start, end + 1).reduce((a, b) => a + b);
  }

  console.log(result.join(' '));
}

numbersSequence(6, 3);