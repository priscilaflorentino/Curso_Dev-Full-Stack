import Input from './components/Input';
import Button from './components/Button';

import { Container, Content, Row, Column } from "./styles";
import { useState } from 'react';

const App =() => {
  const [currentNumber, setCurrentNumber] = useState('0');
  const [firstNumber, setFirstNumber] = useState('0');
  const [operation, setOperation] = useState('');

  const handleAddNumber = (number) => {
    setCurrentNumber(prev => `${prev === '0' ? '': prev}${number}`)
  }

  const handleClear = () => {
    setCurrentNumber('0')
  }

  const handSum = () => {
    if (firstNumber ==='0') {
      setFirstNumber(currentNumber);
      handleClear();
      setOperation('+')
    } else {
      const sum = Number(firstNumber) + Number(currentNumber);
      setCurrentNumber(String(sum));
      setFirstNumber('0')
      setOperation('')
    }
  }

  const handSubtract = () => {
    if (firstNumber === '0') {
      setFirstNumber(currentNumber);
      handleClear();
      setOperation('-')
    } else {
      const sum = Number(firstNumber) - Number(currentNumber);
      setCurrentNumber(String(sum));
      setFirstNumber('0')
      setOperation('')
    }
  }

  const handMultiply = () => {
    if (firstNumber === '0') {
      setFirstNumber(currentNumber);
      handleClear();
      setOperation('*')
    } else {
      const sum = Number(firstNumber) * Number(currentNumber);
      setCurrentNumber(String(sum));
      setFirstNumber('0')
      setOperation('')
    }
  }

  const handDivide = () => {
    if (firstNumber === '0') {
      setFirstNumber(currentNumber);
      handleClear();
      setOperation('/')
    } else {
      const sum = Number(firstNumber) / Number(currentNumber);
      setCurrentNumber(String(sum));
      setFirstNumber('0')
      setOperation('')
    }
  }

  const handEquals = () => {
    if (firstNumber !== '0' && operation !== '' && currentNumber !== '0') {
      switch(operation) {
        case '+':
          handSum();
          break;
        case '-':
          handSubtract();
          break;
        case '*':
          handMultiply();
          break;
        case '/':
          handDivide();
          break;
       default:
         break;
      }
    }
  }
  
  return (
    <Container>
      <Content>
        <Input value={currentNumber}/>
        <Row>
          <Button label="x" onClick={() => handMultiply()}/>
          <Button label="/" onClick={() => handDivide()}/>
          <Button label="c"  onClick={() => handleClear()}/>
       </Row>
        <Row>
          <Button label="7" onClick={() => handleAddNumber('7')}/>
          <Button label="8" onClick={() => handleAddNumber('8')}/>
          <Button label="9" onClick={() => handleAddNumber('9')}/>
          <Button label="-" onClick={() => handSubtract()}/>
       </Row>
       <Row>
          <Button label="4" onClick={() => handleAddNumber('4')}/>
          <Button label="5" onClick={() => handleAddNumber('5')}/>
          <Button label="6" onClick={() => handleAddNumber('6')}/>
          <Button label="+" onClick={() => handSum()}/>
       </Row>
       <Row>
          <Button label="1" onClick={() => handleAddNumber('1')}/>
          <Button label="2" onClick={() => handleAddNumber('2')}/>
          <Button label="3" onClick={() => handleAddNumber('3')}/>
          <Button label="=" onClick={() => handEquals('')}/>
       </Row>
      </Content>
    </Container>
  )
}

export default App;