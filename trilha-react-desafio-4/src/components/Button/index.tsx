import { ButtonContainer } from "./styles";
import { IButtonProps } from "./types";

const onHandleClick = () => {
  console.log('habilitado')
}
const Button = ({ title, valido, onClick }: IButtonProps) => {

  return <ButtonContainer disabled={!valido} onClick={onHandleClick}>{title}</ButtonContainer>;
};
  
export default Button