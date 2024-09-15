import React from 'react'
import { ButtonContainer } from './styles.js';

const Button = ({ onClick }) => {
  return (
    <ButtonContainer onClick={onClick}>
      Buscar
    </ButtonContainer>
  )
}

export default Button;