import React, { useState } from 'react';
import './css/Calculator.css'; // Import Calculator CSS

const Calculator = () => {
  const [num1, setNum1] = useState('');
    const [num2, setNum2] = useState('');
    const [operation, setOperation] = useState('add');
    const [result, setResult] = useState('');

    const handleCompute = () => {
        let computedResult;
        switch (operation) {
            case 'add':
                computedResult = parseFloat(num1) + parseFloat(num2);
                break;
            case 'subtract':
                computedResult = parseFloat(num1) - parseFloat(num2);
                break;
            case 'multiply':
                computedResult = parseFloat(num1) * parseFloat(num2);
                break;
            default:
                computedResult = '';
        }
        setResult(computedResult);
    };

    return (
        <div className="calculator-form">
            <h3>Calculator</h3>
            <form>
                <div className="form-input">
                    <label htmlFor="num1">Enter number 1:</label>
                    <input type="text" id="num1" placeholder="Enter number 1" value={num1} onChange={(e) => setNum1(e.target.value)} />
                </div>
                <div className="form-input">
                    <label htmlFor="num2">Enter number 2:</label>
                    <input type="text" id="num2" placeholder="Enter number 2" value={num2} onChange={(e) => setNum2(e.target.value)} />
                </div>
                <div className="form-input">
                    <label htmlFor="operation">Select operation:</label>
                    <select id="operation" value={operation} onChange={(e) => setOperation(e.target.value)}>
                        <option value="add">Add</option>
                        <option value="subtract">Subtract</option>
                        <option value="multiply">Multiply</option>
                    </select>
                </div>
                <button type="button" onClick={handleCompute}>Compute</button>
            </form>
            <p className="result">Result: {result}</p>
        </div>

    );
}

export default Calculator;
