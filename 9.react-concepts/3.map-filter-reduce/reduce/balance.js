const priceList = [
	{
		preco: 2,
		nome: 'maçã',
	},
	{
		preco: 30,
		nome: 'roupa',
	},
	{
		preco: 25,
		nome: 'carne',
	},
];
const initial = 100;

function balance (arr, initialValue) {
    const finalValue = arr.reduce((initialValue, currentValue) => initialValue - currentValue.preco, initialValue);

    return finalValue;
}

console.log(balance(priceList, initial));
