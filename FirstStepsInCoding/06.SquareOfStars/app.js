function SquareOfStars([n]) {
    n = Number(n);
    console.log('*'.repeat(n));
    for (let i = 0; i < n/2; i++) {
        console.log('*'.repeat(1) + ' '.repeat(n - 2) + '*'.repeat(1));
    }
    console.log('*'.repeat(n));
}

SquareOfStars('4');

SquareOfStars('3');

SquareOfStars('5');