import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
	selector: 'app-calculator',
	templateUrl: './calculator.component.html',
	styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
	@ViewChild('num1', { static: true }) num1: ElementRef<HTMLInputElement> | undefined;
	@ViewChild('num2', { static: true }) num2: ElementRef<HTMLInputElement> | undefined;
	@ViewChild('operation', { static: true }) operation: ElementRef<HTMLInputElement> | undefined;
	result: number = 0;
	constructor() { }
	calculate() {
		let num1Val = 0;
		let num2Val = 0;
		let operationVal = "add";
		if(this.num1){
			num1Val = parseFloat(this.num1.nativeElement.value);
			console.log(num1Val);
		}
		if(this.num2){
			num2Val = parseFloat(this.num2.nativeElement.value);
			console.log(num2Val);
		}
		if(this.operation){
			operationVal = this.operation.nativeElement.value;
		}
		switch (operationVal) {
			case 'add':
				this.result = num1Val + num2Val;
				break;
			case 'subtract':
				this.result = num1Val - num2Val;
				break;
			case 'multiply':
				this.result = num1Val * num2Val;
				break;
		}
	}
}
