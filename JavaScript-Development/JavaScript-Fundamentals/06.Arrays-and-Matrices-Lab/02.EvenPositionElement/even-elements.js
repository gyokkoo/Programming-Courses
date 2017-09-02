function evenElements (args) {
  let evenElements = [];
  for (let i in args) {
    if (i % 2 === 0) {
      evenElements.push(args[i]);
    }
  }

  return evenElements.join(' ');
}

console.log(evenElements(['20', '30', '40']));