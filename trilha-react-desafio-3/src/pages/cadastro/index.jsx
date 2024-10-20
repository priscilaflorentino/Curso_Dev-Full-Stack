import { MdEmail, MdLock } from 'react-icons/md'
import { IoPersonSharp } from 'react-icons/io5'
import { Button } from '../../components/Button';
import { Header } from '../../components/Header';
import { Input } from '../../components/Input';
import { useForm } from "react-hook-form";
import { Container, Title, Column, TitleCadastro, SubtitleCadastro, TenhoConta, FazerLogin, Row, Wrapper } from './styles';

const Cadastro = () => {
    const { control, handleSubmit, formState: { errors  } } = useForm({
        reValidateMode: 'onChange',
        mode: 'onChange',
    });
    const onSubmit = async (formData) => {
        try{
           return

            alert('Usuário ou senha inválido')
        }catch(e){
            //TODO: HOUVE UM ERRO
        }
    };
    
    return (<>
        <Header />
        <Container>
            <Column>
                <Title>A plataforma para você aprender com experts, dominar as principais tecnologias
                 e entrar mais rápido nas empresas mais desejadas.</Title>
            </Column>
            <Column>
                <Wrapper>
                <TitleCadastro>Comece agora grátis</TitleCadastro>
                <SubtitleCadastro>Crie sua conta e faça a diferença</SubtitleCadastro>
                <form onSubmit={handleSubmit(onSubmit)}>
                    <Input placeholder="Nome completo" leftIcon={<IoPersonSharp />} name="nome"  control={control} />
                    {errors.nome && <span>Nome é obrigatório</span>}
                    <Input placeholder="E-mail" leftIcon={<MdEmail />} name="email"  control={control} />
                    {errors.email && <span>E-mail é obrigatório</span>}
                    <Input type="password" placeholder="Senha" leftIcon={<MdLock />}  name="senha" control={control} />
                    {errors.senha && <span>Senha é obrigatório</span>}
                    <Button title="Criar minha conta" variant="secondary" type="submit"/>
                </form>
                <Column>
                <br />
                    Ao clicar em "criar minha conta grátis", declaro que aceito as políticas de privacidade e os termos de uso da DIO.
                    <Row>
                        <TenhoConta>Já tenho conta</TenhoConta>
                        <FazerLogin>Fazer login</FazerLogin>
                    </Row>
                </Column>
                </Wrapper>
            </Column>
        </Container>
    </>)
}

export { Cadastro }